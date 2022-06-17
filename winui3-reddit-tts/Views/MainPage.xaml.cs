using Microsoft.UI.Xaml.Controls;
using System.Globalization;
using System.Speech.Synthesis;
using winui3_reddit_tts.ViewModels;

namespace winui3_reddit_tts.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();

        var synthesizer = new SpeechSynthesizer();
        synthesizer.SetOutputToDefaultAudioDevice();
        synthesizer.SelectVoice("Microsoft Zira Desktop");
        var builder = new PromptBuilder();
        builder.StartVoice(new CultureInfo("en-US"));
        builder.AppendText("Welcome to Frostshoxx's Reddit Feeds Reader");
        builder.EndVoice();
        synthesizer.Speak(builder);
    }
}
