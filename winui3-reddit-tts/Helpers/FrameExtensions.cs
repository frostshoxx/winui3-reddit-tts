using Microsoft.UI.Xaml.Controls;

namespace winui3_reddit_tts.Helpers;

public static class FrameExtensions
{
    public static object GetPageViewModel(this Frame frame) => frame?.Content?.GetType().GetProperty("ViewModel")?.GetValue(frame.Content, null);
}
