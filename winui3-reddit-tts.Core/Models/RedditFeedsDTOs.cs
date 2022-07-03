using System.Collections.Generic;
using Newtonsoft.Json;

namespace winui3_reddit_tts.Core.Models;

// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
public class AllAwarding
{
    [JsonProperty("giver_coin_reward")]
    public object GiverCoinReward
    {
        get; set;
    }

    [JsonProperty("subreddit_id")]
    public object SubredditId
    {
        get; set;
    }

    [JsonProperty("is_new")]
    public bool IsNew
    {
        get; set;
    }

    [JsonProperty("days_of_drip_extension")]
    public object DaysOfDripExtension
    {
        get; set;
    }

    [JsonProperty("coin_price")]
    public int CoinPrice
    {
        get; set;
    }

    [JsonProperty("id")]
    public string Id
    {
        get; set;
    }

    [JsonProperty("penny_donate")]
    public object PennyDonate
    {
        get; set;
    }

    [JsonProperty("award_sub_type")]
    public string AwardSubType
    {
        get; set;
    }

    [JsonProperty("coin_reward")]
    public int CoinReward
    {
        get; set;
    }

    [JsonProperty("icon_url")]
    public string IconUrl
    {
        get; set;
    }

    [JsonProperty("days_of_premium")]
    public int? DaysOfPremium
    {
        get; set;
    }

    [JsonProperty("tiers_by_required_awardings")]
    public object TiersByRequiredAwardings
    {
        get; set;
    }

    [JsonProperty("resized_icons")]
    public List<ResizedIcon> ResizedIcons
    {
        get; set;
    }

    [JsonProperty("icon_width")]
    public int IconWidth
    {
        get; set;
    }

    [JsonProperty("static_icon_width")]
    public int StaticIconWidth
    {
        get; set;
    }

    [JsonProperty("start_date")]
    public object StartDate
    {
        get; set;
    }

    [JsonProperty("is_enabled")]
    public bool IsEnabled
    {
        get; set;
    }

    [JsonProperty("awardings_required_to_grant_benefits")]
    public object AwardingsRequiredToGrantBenefits
    {
        get; set;
    }

    [JsonProperty("description")]
    public string Description
    {
        get; set;
    }

    [JsonProperty("end_date")]
    public object EndDate
    {
        get; set;
    }

    [JsonProperty("sticky_duration_seconds")]
    public object StickyDurationSeconds
    {
        get; set;
    }

    [JsonProperty("subreddit_coin_reward")]
    public int SubredditCoinReward
    {
        get; set;
    }

    [JsonProperty("count")]
    public int Count
    {
        get; set;
    }

    [JsonProperty("static_icon_height")]
    public int StaticIconHeight
    {
        get; set;
    }

    [JsonProperty("name")]
    public string Name
    {
        get; set;
    }

    [JsonProperty("resized_static_icons")]
    public List<ResizedStaticIcon> ResizedStaticIcons
    {
        get; set;
    }

    [JsonProperty("icon_format")]
    public string IconFormat
    {
        get; set;
    }

    [JsonProperty("icon_height")]
    public int IconHeight
    {
        get; set;
    }

    [JsonProperty("penny_price")]
    public int? PennyPrice
    {
        get; set;
    }

    [JsonProperty("award_type")]
    public string AwardType
    {
        get; set;
    }

    [JsonProperty("static_icon_url")]
    public string StaticIconUrl
    {
        get; set;
    }
}

public class RedditFeedResult
{
    [JsonProperty("kind")]
    public string Kind
    {
        get; set;
    }

    [JsonProperty("data")]
    public Data Data
    {
        get; set;
    }
}

public class Data
{
    [JsonProperty("after")]
    public string After
    {
        get; set;
    }

    [JsonProperty("dist")]
    public int Dist
    {
        get; set;
    }

    [JsonProperty("modhash")]
    public string Modhash
    {
        get; set;
    }

    [JsonProperty("geo_filter")]
    public object GeoFilter
    {
        get; set;
    }

    [JsonProperty("children")]
    public List<RedditFeedResult> Children
    {
        get; set;
    }

    [JsonProperty("before")]
    public object Before
    {
        get; set;
    }

    [JsonProperty("approved_at_utc")]
    public object ApprovedAtUtc
    {
        get; set;
    }

    [JsonProperty("subreddit")]
    public string Subreddit
    {
        get; set;
    }

    [JsonProperty("selftext")]
    public string Selftext
    {
        get; set;
    }

    [JsonProperty("author_fullname")]
    public string AuthorFullname
    {
        get; set;
    }

    [JsonProperty("saved")]
    public bool Saved
    {
        get; set;
    }

    [JsonProperty("mod_reason_title")]
    public object ModReasonTitle
    {
        get; set;
    }

    [JsonProperty("gilded")]
    public int Gilded
    {
        get; set;
    }

    [JsonProperty("clicked")]
    public bool Clicked
    {
        get; set;
    }

    [JsonProperty("title")]
    public string Title
    {
        get; set;
    }

    [JsonProperty("link_flair_richtext")]
    public List<object> LinkFlairRichtext
    {
        get; set;
    }

    [JsonProperty("subreddit_name_prefixed")]
    public string SubredditNamePrefixed
    {
        get; set;
    }

    [JsonProperty("hidden")]
    public bool Hidden
    {
        get; set;
    }

    [JsonProperty("pwls")]
    public int? Pwls
    {
        get; set;
    }

    [JsonProperty("link_flair_css_class")]
    public string LinkFlairCssClass
    {
        get; set;
    }

    [JsonProperty("downs")]
    public int Downs
    {
        get; set;
    }

    [JsonProperty("thumbnail_height")]
    public int? ThumbnailHeight
    {
        get; set;
    }

    [JsonProperty("top_awarded_type")]
    public object TopAwardedType
    {
        get; set;
    }

    [JsonProperty("hide_score")]
    public bool HideScore
    {
        get; set;
    }

    [JsonProperty("name")]
    public string Name
    {
        get; set;
    }

    [JsonProperty("quarantine")]
    public bool Quarantine
    {
        get; set;
    }

    [JsonProperty("link_flair_text_color")]
    public string LinkFlairTextColor
    {
        get; set;
    }

    [JsonProperty("upvote_ratio")]
    public double UpvoteRatio
    {
        get; set;
    }

    [JsonProperty("author_flair_background_color")]
    public string AuthorFlairBackgroundColor
    {
        get; set;
    }

    [JsonProperty("subreddit_type")]
    public string SubredditType
    {
        get; set;
    }

    [JsonProperty("ups")]
    public int Ups
    {
        get; set;
    }

    [JsonProperty("total_awards_received")]
    public int TotalAwardsReceived
    {
        get; set;
    }

    [JsonProperty("media_embed")]
    public MediaEmbed MediaEmbed
    {
        get; set;
    }

    [JsonProperty("thumbnail_width")]
    public int? ThumbnailWidth
    {
        get; set;
    }

    [JsonProperty("author_flair_template_id")]
    public string AuthorFlairTemplateId
    {
        get; set;
    }

    [JsonProperty("is_original_content")]
    public bool IsOriginalContent
    {
        get; set;
    }

    [JsonProperty("user_reports")]
    public List<object> UserReports
    {
        get; set;
    }

    [JsonProperty("secure_media")]
    public object SecureMedia
    {
        get; set;
    }

    [JsonProperty("is_reddit_media_domain")]
    public bool IsRedditMediaDomain
    {
        get; set;
    }

    [JsonProperty("is_meta")]
    public bool IsMeta
    {
        get; set;
    }

    [JsonProperty("category")]
    public object Category
    {
        get; set;
    }

    [JsonProperty("secure_media_embed")]
    public SecureMediaEmbed SecureMediaEmbed
    {
        get; set;
    }

    [JsonProperty("link_flair_text")]
    public string LinkFlairText
    {
        get; set;
    }

    [JsonProperty("can_mod_post")]
    public bool CanModPost
    {
        get; set;
    }

    [JsonProperty("score")]
    public int Score
    {
        get; set;
    }

    [JsonProperty("approved_by")]
    public object ApprovedBy
    {
        get; set;
    }

    [JsonProperty("is_created_from_ads_ui")]
    public bool IsCreatedFromAdsUi
    {
        get; set;
    }

    [JsonProperty("author_premium")]
    public bool AuthorPremium
    {
        get; set;
    }

    [JsonProperty("thumbnail")]
    public string Thumbnail
    {
        get; set;
    }

    [JsonProperty("edited")]
    public bool Edited
    {
        get; set;
    }

    [JsonProperty("author_flair_css_class")]
    public string AuthorFlairCssClass
    {
        get; set;
    }

    [JsonProperty("author_flair_richtext")]
    public List<object> AuthorFlairRichtext
    {
        get; set;
    }

    [JsonProperty("gildings")]
    public Gildings Gildings
    {
        get; set;
    }

    [JsonProperty("post_hint")]
    public string PostHint
    {
        get; set;
    }

    [JsonProperty("content_categories")]
    public object ContentCategories
    {
        get; set;
    }

    [JsonProperty("is_self")]
    public bool IsSelf
    {
        get; set;
    }

    [JsonProperty("mod_note")]
    public object ModNote
    {
        get; set;
    }

    [JsonProperty("created")]
    public double Created
    {
        get; set;
    }

    [JsonProperty("link_flair_type")]
    public string LinkFlairType
    {
        get; set;
    }

    [JsonProperty("wls")]
    public int? Wls
    {
        get; set;
    }

    [JsonProperty("removed_by_category")]
    public object RemovedByCategory
    {
        get; set;
    }

    [JsonProperty("banned_by")]
    public object BannedBy
    {
        get; set;
    }

    [JsonProperty("author_flair_type")]
    public string AuthorFlairType
    {
        get; set;
    }

    [JsonProperty("domain")]
    public string Domain
    {
        get; set;
    }

    [JsonProperty("allow_live_comments")]
    public bool AllowLiveComments
    {
        get; set;
    }

    [JsonProperty("selftext_html")]
    public object SelftextHtml
    {
        get; set;
    }

    [JsonProperty("likes")]
    public object Likes
    {
        get; set;
    }

    [JsonProperty("suggested_sort")]
    public string SuggestedSort
    {
        get; set;
    }

    [JsonProperty("banned_at_utc")]
    public object BannedAtUtc
    {
        get; set;
    }

    [JsonProperty("url_overridden_by_dest")]
    public string UrlOverriddenByDest
    {
        get; set;
    }

    [JsonProperty("view_count")]
    public object ViewCount
    {
        get; set;
    }

    [JsonProperty("archived")]
    public bool Archived
    {
        get; set;
    }

    [JsonProperty("no_follow")]
    public bool NoFollow
    {
        get; set;
    }

    [JsonProperty("is_crosspostable")]
    public bool IsCrosspostable
    {
        get; set;
    }

    [JsonProperty("pinned")]
    public bool Pinned
    {
        get; set;
    }

    [JsonProperty("over_18")]
    public bool Over18
    {
        get; set;
    }

    [JsonProperty("preview")]
    public Preview Preview
    {
        get; set;
    }

    [JsonProperty("all_awardings")]
    public List<AllAwarding> AllAwardings
    {
        get; set;
    }

    [JsonProperty("awarders")]
    public List<object> Awarders
    {
        get; set;
    }

    [JsonProperty("media_only")]
    public bool MediaOnly
    {
        get; set;
    }

    [JsonProperty("can_gild")]
    public bool CanGild
    {
        get; set;
    }

    [JsonProperty("spoiler")]
    public bool Spoiler
    {
        get; set;
    }

    [JsonProperty("locked")]
    public bool Locked
    {
        get; set;
    }

    [JsonProperty("author_flair_text")]
    public string AuthorFlairText
    {
        get; set;
    }

    [JsonProperty("treatment_tags")]
    public List<object> TreatmentTags
    {
        get; set;
    }

    [JsonProperty("visited")]
    public bool Visited
    {
        get; set;
    }

    [JsonProperty("removed_by")]
    public object RemovedBy
    {
        get; set;
    }

    [JsonProperty("num_reports")]
    public object NumReports
    {
        get; set;
    }

    [JsonProperty("distinguished")]
    public object Distinguished
    {
        get; set;
    }

    [JsonProperty("subreddit_id")]
    public string SubredditId
    {
        get; set;
    }

    [JsonProperty("author_is_blocked")]
    public bool AuthorIsBlocked
    {
        get; set;
    }

    [JsonProperty("mod_reason_by")]
    public object ModReasonBy
    {
        get; set;
    }

    [JsonProperty("removal_reason")]
    public object RemovalReason
    {
        get; set;
    }

    [JsonProperty("link_flair_background_color")]
    public string LinkFlairBackgroundColor
    {
        get; set;
    }

    [JsonProperty("id")]
    public string Id
    {
        get; set;
    }

    [JsonProperty("is_robot_indexable")]
    public bool IsRobotIndexable
    {
        get; set;
    }

    [JsonProperty("report_reasons")]
    public object ReportReasons
    {
        get; set;
    }

    [JsonProperty("author")]
    public string Author
    {
        get; set;
    }

    [JsonProperty("discussion_type")]
    public object DiscussionType
    {
        get; set;
    }

    [JsonProperty("num_comments")]
    public int NumComments
    {
        get; set;
    }

    [JsonProperty("send_replies")]
    public bool SendReplies
    {
        get; set;
    }

    [JsonProperty("whitelist_status")]
    public string WhitelistStatus
    {
        get; set;
    }

    [JsonProperty("contest_mode")]
    public bool ContestMode
    {
        get; set;
    }

    [JsonProperty("mod_reports")]
    public List<object> ModReports
    {
        get; set;
    }

    [JsonProperty("author_patreon_flair")]
    public bool AuthorPatreonFlair
    {
        get; set;
    }

    [JsonProperty("author_flair_text_color")]
    public string AuthorFlairTextColor
    {
        get; set;
    }

    [JsonProperty("permalink")]
    public string Permalink
    {
        get; set;
    }

    [JsonProperty("parent_whitelist_status")]
    public string ParentWhitelistStatus
    {
        get; set;
    }

    [JsonProperty("stickied")]
    public bool Stickied
    {
        get; set;
    }

    [JsonProperty("url")]
    public string Url
    {
        get; set;
    }

    [JsonProperty("subreddit_subscribers")]
    public int SubredditSubscribers
    {
        get; set;
    }

    [JsonProperty("created_utc")]
    public double CreatedUtc
    {
        get; set;
    }

    [JsonProperty("num_crossposts")]
    public int NumCrossposts
    {
        get; set;
    }

    [JsonProperty("media")]
    public object Media
    {
        get; set;
    }

    [JsonProperty("is_video")]
    public bool IsVideo
    {
        get; set;
    }

    [JsonProperty("tournament_data")]
    public TournamentData TournamentData
    {
        get; set;
    }

    [JsonProperty("link_flair_template_id")]
    public string LinkFlairTemplateId
    {
        get; set;
    }
}

public class Gildings
{
    [JsonProperty("gid_1")]
    public int Gid1
    {
        get; set;
    }

    [JsonProperty("gid_2")]
    public int? Gid2
    {
        get; set;
    }
}

public class Image
{
    [JsonProperty("source")]
    public Source Source
    {
        get; set;
    }

    [JsonProperty("resolutions")]
    public List<Resolution> Resolutions
    {
        get; set;
    }

    [JsonProperty("variants")]
    public Variants Variants
    {
        get; set;
    }

    [JsonProperty("id")]
    public string Id
    {
        get; set;
    }
}

public class MediaEmbed
{
}

public class Option
{
    [JsonProperty("total_amount")]
    public int TotalAmount
    {
        get; set;
    }

    [JsonProperty("text")]
    public string Text
    {
        get; set;
    }

    [JsonProperty("vote_count")]
    public int VoteCount
    {
        get; set;
    }

    [JsonProperty("user_amount")]
    public object UserAmount
    {
        get; set;
    }

    [JsonProperty("image_url")]
    public object ImageUrl
    {
        get; set;
    }

    [JsonProperty("id")]
    public string Id
    {
        get; set;
    }
}

public class Prediction
{
    [JsonProperty("status")]
    public string Status
    {
        get; set;
    }

    [JsonProperty("body")]
    public string Body
    {
        get; set;
    }

    [JsonProperty("is_rtjson")]
    public bool IsRtjson
    {
        get; set;
    }

    [JsonProperty("is_nsfw")]
    public bool IsNsfw
    {
        get; set;
    }

    [JsonProperty("title")]
    public string Title
    {
        get; set;
    }

    [JsonProperty("created_at")]
    public object CreatedAt
    {
        get; set;
    }

    [JsonProperty("voting_end_timestamp")]
    public object VotingEndTimestamp
    {
        get; set;
    }

    [JsonProperty("id")]
    public string Id
    {
        get; set;
    }

    [JsonProperty("vote_updates_remained")]
    public object VoteUpdatesRemained
    {
        get; set;
    }

    [JsonProperty("resolved_option_id")]
    public string ResolvedOptionId
    {
        get; set;
    }

    [JsonProperty("user_won_amount")]
    public object UserWonAmount
    {
        get; set;
    }

    [JsonProperty("is_spoiler")]
    public bool IsSpoiler
    {
        get; set;
    }

    [JsonProperty("user_selection")]
    public object UserSelection
    {
        get; set;
    }

    [JsonProperty("options")]
    public List<Option> Options
    {
        get; set;
    }

    [JsonProperty("total_stake_amount")]
    public int TotalStakeAmount
    {
        get; set;
    }

    [JsonProperty("total_vote_count")]
    public int TotalVoteCount
    {
        get; set;
    }
}

public class Preview
{
    [JsonProperty("images")]
    public List<Image> Images
    {
        get; set;
    }

    [JsonProperty("enabled")]
    public bool Enabled
    {
        get; set;
    }
}

public class ResizedIcon
{
    [JsonProperty("url")]
    public string Url
    {
        get; set;
    }

    [JsonProperty("width")]
    public int Width
    {
        get; set;
    }

    [JsonProperty("height")]
    public int Height
    {
        get; set;
    }
}

public class ResizedStaticIcon
{
    [JsonProperty("url")]
    public string Url
    {
        get; set;
    }

    [JsonProperty("width")]
    public int Width
    {
        get; set;
    }

    [JsonProperty("height")]
    public int Height
    {
        get; set;
    }
}

public class Resolution
{
    [JsonProperty("url")]
    public string Url
    {
        get; set;
    }

    [JsonProperty("width")]
    public int Width
    {
        get; set;
    }

    [JsonProperty("height")]
    public int Height
    {
        get; set;
    }
}

public class Root
{
    [JsonProperty("kind")]
    public string Kind
    {
        get; set;
    }

    [JsonProperty("data")]
    public Data Data
    {
        get; set;
    }
}

public class SecureMediaEmbed
{
}

public class Source
{
    [JsonProperty("url")]
    public string Url
    {
        get; set;
    }

    [JsonProperty("width")]
    public int Width
    {
        get; set;
    }

    [JsonProperty("height")]
    public int Height
    {
        get; set;
    }
}

public class TournamentData
{
    [JsonProperty("status")]
    public string Status
    {
        get; set;
    }

    [JsonProperty("total_participants")]
    public int TotalParticipants
    {
        get; set;
    }

    [JsonProperty("subreddit_id")]
    public string SubredditId
    {
        get; set;
    }

    [JsonProperty("name")]
    public string Name
    {
        get; set;
    }

    [JsonProperty("predictions")]
    public List<Prediction> Predictions
    {
        get; set;
    }

    [JsonProperty("currency")]
    public string Currency
    {
        get; set;
    }

    [JsonProperty("theme_id")]
    public string ThemeId
    {
        get; set;
    }

    [JsonProperty("tournament_id")]
    public string TournamentId
    {
        get; set;
    }
}

public class Variants
{
}

