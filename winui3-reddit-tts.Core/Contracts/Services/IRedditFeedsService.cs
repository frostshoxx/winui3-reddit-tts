using System.Net.Http;
using System.Threading.Tasks;
using winui3_reddit_tts.Core.Models;

namespace winui3_reddit_tts.Core.Contracts.Services;

public interface IRedditFeedsService
{
    public Task<RedditFeedResult> GetRedditFeeds(HttpClient httpClient);
}
