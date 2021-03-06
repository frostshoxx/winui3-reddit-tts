using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.UI.Xaml;
using System.Globalization;
using System.Net.Http;
using System.Speech.Synthesis;
using System.Threading.Tasks;
using winui3_reddit_tts.Activation;
using winui3_reddit_tts.Contracts.Services;
using winui3_reddit_tts.Core.Contracts.Services;
using winui3_reddit_tts.Core.Services;
using winui3_reddit_tts.Helpers;
using winui3_reddit_tts.Models;
using winui3_reddit_tts.Services;
using winui3_reddit_tts.ViewModels;
using winui3_reddit_tts.Views;

// To learn more about WinUI3, see: https://docs.microsoft.com/windows/apps/winui/winui3/.
namespace winui3_reddit_tts;

public partial class App : Application
{
    // The .NET Generic Host provides dependency injection, configuration, logging, and other services.
    // https://docs.microsoft.com/dotnet/core/extensions/generic-host
    // https://docs.microsoft.com/dotnet/core/extensions/dependency-injection
    // https://docs.microsoft.com/dotnet/core/extensions/configuration
    // https://docs.microsoft.com/dotnet/core/extensions/logging
    private static readonly IHost _host = Host
        .CreateDefaultBuilder()
        .ConfigureServices((context, services) =>
        {
            // Default Activation Handler
            services.AddTransient<ActivationHandler<LaunchActivatedEventArgs>, DefaultActivationHandler>();

            // Other Activation Handlers

            // Services
            services.AddSingleton<IThemeSelectorService, ThemeSelectorService>();
            services.AddSingleton<ILocalSettingsService, LocalSettingsServicePackaged>();
            services.AddTransient<INavigationViewService, NavigationViewService>();

            services.AddSingleton<IActivationService, ActivationService>();
            services.AddSingleton<IPageService, PageService>();
            services.AddSingleton<INavigationService, NavigationService>();

            // Core Services
            services.AddSingleton<IRedditFeedsService, RedditFeedsService>();

            // Views and ViewModels
            services.AddTransient<MainViewModel>();
            services.AddTransient<MainPage>();
            services.AddTransient<ShellPage>();
            services.AddTransient<ShellViewModel>();

            // Configuration
            services.Configure<LocalSettingsOptions>(context.Configuration.GetSection(nameof(LocalSettingsOptions)));

        })
        .Build();

    public static T GetService<T>()
        where T : class
    {
        return _host.Services.GetService(typeof(T)) as T;
    }

    public static Window MainWindow { get; set; } = new Window() { Title = "AppDisplayName".GetLocalized() };

    public App()
    {
        InitializeComponent();
        UnhandledException += App_UnhandledException;
    }

    public HttpClient HttpClient { get; } = new HttpClient();
    public SpeechSynthesizer Synthesizer { get; } = new SpeechSynthesizer();
    public IRedditFeedsService RedditFeedsService { get; } = new RedditFeedsService();

    private void App_UnhandledException(object sender, UnhandledExceptionEventArgs e)
    {
        // TODO: Log and handle exceptions as appropriate.
        // For more details, see https://docs.microsoft.com/windows/winui/api/microsoft.ui.xaml.unhandledexceptioneventargs.
    }

    protected async override void OnLaunched(LaunchActivatedEventArgs args)
    {
        base.OnLaunched(args);
        var activationService = App.GetService<IActivationService>();
        await activationService.ActivateAsync(args);

        await Task.Run(() =>
        {
            Synthesizer.SetOutputToDefaultAudioDevice();
            Synthesizer.SelectVoice("Microsoft Zira Desktop");
            var builder = new PromptBuilder();
            builder.StartVoice(new CultureInfo("en-US"));
            builder.AppendText("Welcome to Frostshoxx's Reddit Feeds Reader");
            builder.EndVoice();
            Synthesizer.Speak(builder);
        });
    }
}
