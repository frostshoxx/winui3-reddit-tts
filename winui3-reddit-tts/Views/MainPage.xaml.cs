using System.Globalization;
using System.Net.Http;
using System.Speech.Synthesis;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using winui3_reddit_tts.Core.Helpers;
using winui3_reddit_tts.Models;
using winui3_reddit_tts.ViewModels;

namespace winui3_reddit_tts.Views;

public sealed partial class MainPage : Page
{
    private readonly HttpClient _httpClient;
    private const string _redditUrl = "https://www.reddit.com/hot/.json?limit=10";

    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
        _httpClient = (App.Current as App)?.HttpClient;
    }

    async void LoadRedditFeeds(object sender, RoutedEventArgs e)
    {
        Feeds.Text = "";
        var responseString = await _httpClient.GetStringAsync(_redditUrl);
        var feeds = await Json.ToObjectAsync<Child>(responseString);

        foreach (var feed in feeds.Data.Children)
        {
            Feeds.Text += $"{feed.Data.Title}\n";
        }
    }

    void ReadRedditFeeds(object sender, RoutedEventArgs e)
    {
        var synthesizer = (App.Current as App)?.Synthesizer;
        synthesizer.SetOutputToDefaultAudioDevice();
        synthesizer.SelectVoice("Microsoft Zira Desktop");
        var builder = new PromptBuilder();
        builder.StartVoice(new CultureInfo("en-US"));
        builder.AppendText("Here's what's hot on Reddit right now!");
        builder.AppendText(Feeds.Text);
        builder.AppendText("That's it, folks! Thanks for listening.");
        builder.EndVoice();
        synthesizer.Speak(builder);
    }
}
