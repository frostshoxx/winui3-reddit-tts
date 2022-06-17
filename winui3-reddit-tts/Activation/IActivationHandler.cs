using System.Threading.Tasks;

namespace winui3_reddit_tts.Activation;

public interface IActivationHandler
{
    bool CanHandle(object args);

    Task HandleAsync(object args);
}
