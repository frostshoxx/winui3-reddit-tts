using System.Globalization;
using System.Net.Http;
using System.Speech.Synthesis;
using System.Threading.Tasks;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using winui3_reddit_tts.Core.Contracts.Services;
using winui3_reddit_tts.ViewModels;

namespace winui3_reddit_tts.Views;

public sealed partial class MainPage : Page
{
    private readonly HttpClient _httpClient;
    private readonly SpeechSynthesizer _synthesizer;
    private readonly IRedditFeedsService _redditFeedsService;

    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
        _httpClient = (App.Current as App)?.HttpClient;
        _synthesizer = (App.Current as App)?.Synthesizer;
        _redditFeedsService = (App.Current as App)?.RedditFeedsService;
    }

    async void LoadRedditFeeds(object sender, RoutedEventArgs e)
    {
        Feeds.Text = "";
        var feeds = await _redditFeedsService.GetRedditFeeds(_httpClient);

        foreach (var feed in feeds.Data.Children)
        {
            Feeds.Text += $"{feed.Data.Title}\n";
        }
    }

    async void ReadRedditFeeds(object sender, RoutedEventArgs e)
    {
        var textToRead = Feeds.Text;
        await Task.Run(() =>
        {
            _synthesizer.SetOutputToDefaultAudioDevice();
            _synthesizer.SelectVoice("Microsoft Zira Desktop");
            var builder = new PromptBuilder();
            builder.StartVoice(new CultureInfo("en-US"));
            builder.AppendText("Here's what's hot on Reddit right now!");
            builder.AppendText(textToRead);
            builder.AppendText("That's it, folks! Thanks for listening.");
            builder.EndVoice();
            _synthesizer.Speak(builder);
        });
    }
}
