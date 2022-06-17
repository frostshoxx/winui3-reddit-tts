using System.Threading.Tasks;

namespace winui3_reddit_tts.Contracts.Services;

public interface IActivationService
{
    Task ActivateAsync(object activationArgs);
}
