using System.Net.Http;
using System.Threading.Tasks;
using winui3_reddit_tts.Core.Contracts.Services;
using winui3_reddit_tts.Core.Helpers;
using winui3_reddit_tts.Core.Models;

namespace winui3_reddit_tts.Core.Services;

public class RedditFeedsService : IRedditFeedsService
{
    private const string _redditUrl = "https://www.reddit.com/hot/.json?limit=10";

    public async Task<RedditFeedResult> GetRedditFeeds(HttpClient httpClient)
    {
        var responseString = await httpClient.GetStringAsync(_redditUrl);
        var feeds = await Json.ToObjectAsync<RedditFeedResult>(responseString);

        return feeds;
    }
}
