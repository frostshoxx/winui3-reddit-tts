using Microsoft.UI.Xaml.Controls;

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
    }
}
