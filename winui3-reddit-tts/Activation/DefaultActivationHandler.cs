using System;
using System.Threading.Tasks;

using Microsoft.UI.Xaml;

using winui3_reddit_tts.Contracts.Services;
using winui3_reddit_tts.ViewModels;

namespace winui3_reddit_tts.Activation;

public class DefaultActivationHandler : ActivationHandler<LaunchActivatedEventArgs>
{
    private readonly INavigationService _navigationService;

    public DefaultActivationHandler(INavigationService navigationService)
    {
        _navigationService = navigationService;
    }

    protected override bool CanHandleInternal(LaunchActivatedEventArgs args)
    {
        // None of the ActivationHandlers has handled the activation.
        return _navigationService.Frame.Content == null;
    }

    protected async override Task HandleInternalAsync(LaunchActivatedEventArgs args)
    {
        _navigationService.NavigateTo(typeof(MainViewModel).FullName, args.Arguments);

        await Task.CompletedTask;
    }
}
