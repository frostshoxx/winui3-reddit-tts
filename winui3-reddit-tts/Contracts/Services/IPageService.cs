using System;

namespace winui3_reddit_tts.Contracts.Services;

public interface IPageService
{
    Type GetPageType(string key);
}
