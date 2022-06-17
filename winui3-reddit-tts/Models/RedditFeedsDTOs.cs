using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace winui3_reddit_tts.Models;

// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
public class AllAwarding
{
    [JsonPropertyName("giver_coin_reward")]
    public object GiverCoinReward
    {
        get; set;
    }

    [JsonPropertyName("subreddit_id")]
    public object SubredditId
    {
        get; set;
    }

    [JsonPropertyName("is_new")]
    public bool IsNew
    {
        get; set;
    }

    [JsonPropertyName("days_of_drip_extension")]
    public object DaysOfDripExtension
    {
        get; set;
    }

    [JsonPropertyName("coin_price")]
    public int CoinPrice
    {
        get; set;
    }

    [JsonPropertyName("id")]
    public string Id
    {
        get; set;
    }

    [JsonPropertyName("penny_donate")]
    public object PennyDonate
    {
        get; set;
    }

    [JsonPropertyName("award_sub_type")]
    public string AwardSubType
    {
        get; set;
    }

    [JsonPropertyName("coin_reward")]
    public int CoinReward
    {
        get; set;
    }

    [JsonPropertyName("icon_url")]
    public string IconUrl
    {
        get; set;
    }

    [JsonPropertyName("days_of_premium")]
    public int? DaysOfPremium
    {
        get; set;
    }

    [JsonPropertyName("tiers_by_required_awardings")]
    public object TiersByRequiredAwardings
    {
        get; set;
    }

    [JsonPropertyName("resized_icons")]
    public List<ResizedIcon> ResizedIcons
    {
        get; set;
    }

    [JsonPropertyName("icon_width")]
    public int IconWidth
    {
        get; set;
    }

    [JsonPropertyName("static_icon_width")]
    public int StaticIconWidth
    {
        get; set;
    }

    [JsonPropertyName("start_date")]
    public object StartDate
    {
        get; set;
    }

    [JsonPropertyName("is_enabled")]
    public bool IsEnabled
    {
        get; set;
    }

    [JsonPropertyName("awardings_required_to_grant_benefits")]
    public object AwardingsRequiredToGrantBenefits
    {
        get; set;
    }

    [JsonPropertyName("description")]
    public string Description
    {
        get; set;
    }

    [JsonPropertyName("end_date")]
    public object EndDate
    {
        get; set;
    }

    [JsonPropertyName("sticky_duration_seconds")]
    public object StickyDurationSeconds
    {
        get; set;
    }

    [JsonPropertyName("subreddit_coin_reward")]
    public int SubredditCoinReward
    {
        get; set;
    }

    [JsonPropertyName("count")]
    public int Count
    {
        get; set;
    }

    [JsonPropertyName("static_icon_height")]
    public int StaticIconHeight
    {
        get; set;
    }

    [JsonPropertyName("name")]
    public string Name
    {
        get; set;
    }

    [JsonPropertyName("resized_static_icons")]
    public List<ResizedStaticIcon> ResizedStaticIcons
    {
        get; set;
    }

    [JsonPropertyName("icon_format")]
    public string IconFormat
    {
        get; set;
    }

    [JsonPropertyName("icon_height")]
    public int IconHeight
    {
        get; set;
    }

    [JsonPropertyName("penny_price")]
    public int? PennyPrice
    {
        get; set;
    }

    [JsonPropertyName("award_type")]
    public string AwardType
    {
        get; set;
    }

    [JsonPropertyName("static_icon_url")]
    public string StaticIconUrl
    {
        get; set;
    }
}

public class Child
{
    [JsonPropertyName("kind")]
    public string Kind
    {
        get; set;
    }

    [JsonPropertyName("data")]
    public Data Data
    {
        get; set;
    }
}

public class Data
{
    [JsonPropertyName("after")]
    public string After
    {
        get; set;
    }

    [JsonPropertyName("dist")]
    public int Dist
    {
        get; set;
    }

    [JsonPropertyName("modhash")]
    public string Modhash
    {
        get; set;
    }

    [JsonPropertyName("geo_filter")]
    public object GeoFilter
    {
        get; set;
    }

    [JsonPropertyName("children")]
    public List<Child> Children
    {
        get; set;
    }

    [JsonPropertyName("before")]
    public object Before
    {
        get; set;
    }

    [JsonPropertyName("approved_at_utc")]
    public object ApprovedAtUtc
    {
        get; set;
    }

    [JsonPropertyName("subreddit")]
    public string Subreddit
    {
        get; set;
    }

    [JsonPropertyName("selftext")]
    public string Selftext
    {
        get; set;
    }

    [JsonPropertyName("author_fullname")]
    public string AuthorFullname
    {
        get; set;
    }

    [JsonPropertyName("saved")]
    public bool Saved
    {
        get; set;
    }

    [JsonPropertyName("mod_reason_title")]
    public object ModReasonTitle
    {
        get; set;
    }

    [JsonPropertyName("gilded")]
    public int Gilded
    {
        get; set;
    }

    [JsonPropertyName("clicked")]
    public bool Clicked
    {
        get; set;
    }

    [JsonPropertyName("title")]
    public string Title
    {
        get; set;
    }

    [JsonPropertyName("link_flair_richtext")]
    public List<object> LinkFlairRichtext
    {
        get; set;
    }

    [JsonPropertyName("subreddit_name_prefixed")]
    public string SubredditNamePrefixed
    {
        get; set;
    }

    [JsonPropertyName("hidden")]
    public bool Hidden
    {
        get; set;
    }

    [JsonPropertyName("pwls")]
    public int Pwls
    {
        get; set;
    }

    [JsonPropertyName("link_flair_css_class")]
    public string LinkFlairCssClass
    {
        get; set;
    }

    [JsonPropertyName("downs")]
    public int Downs
    {
        get; set;
    }

    [JsonPropertyName("thumbnail_height")]
    public int? ThumbnailHeight
    {
        get; set;
    }

    [JsonPropertyName("top_awarded_type")]
    public object TopAwardedType
    {
        get; set;
    }

    [JsonPropertyName("hide_score")]
    public bool HideScore
    {
        get; set;
    }

    [JsonPropertyName("name")]
    public string Name
    {
        get; set;
    }

    [JsonPropertyName("quarantine")]
    public bool Quarantine
    {
        get; set;
    }

    [JsonPropertyName("link_flair_text_color")]
    public string LinkFlairTextColor
    {
        get; set;
    }

    [JsonPropertyName("upvote_ratio")]
    public double UpvoteRatio
    {
        get; set;
    }

    [JsonPropertyName("author_flair_background_color")]
    public string AuthorFlairBackgroundColor
    {
        get; set;
    }

    [JsonPropertyName("subreddit_type")]
    public string SubredditType
    {
        get; set;
    }

    [JsonPropertyName("ups")]
    public int Ups
    {
        get; set;
    }

    [JsonPropertyName("total_awards_received")]
    public int TotalAwardsReceived
    {
        get; set;
    }

    [JsonPropertyName("media_embed")]
    public MediaEmbed MediaEmbed
    {
        get; set;
    }

    [JsonPropertyName("thumbnail_width")]
    public int? ThumbnailWidth
    {
        get; set;
    }

    [JsonPropertyName("author_flair_template_id")]
    public string AuthorFlairTemplateId
    {
        get; set;
    }

    [JsonPropertyName("is_original_content")]
    public bool IsOriginalContent
    {
        get; set;
    }

    [JsonPropertyName("user_reports")]
    public List<object> UserReports
    {
        get; set;
    }

    [JsonPropertyName("secure_media")]
    public object SecureMedia
    {
        get; set;
    }

    [JsonPropertyName("is_reddit_media_domain")]
    public bool IsRedditMediaDomain
    {
        get; set;
    }

    [JsonPropertyName("is_meta")]
    public bool IsMeta
    {
        get; set;
    }

    [JsonPropertyName("category")]
    public object Category
    {
        get; set;
    }

    [JsonPropertyName("secure_media_embed")]
    public SecureMediaEmbed SecureMediaEmbed
    {
        get; set;
    }

    [JsonPropertyName("link_flair_text")]
    public string LinkFlairText
    {
        get; set;
    }

    [JsonPropertyName("can_mod_post")]
    public bool CanModPost
    {
        get; set;
    }

    [JsonPropertyName("score")]
    public int Score
    {
        get; set;
    }

    [JsonPropertyName("approved_by")]
    public object ApprovedBy
    {
        get; set;
    }

    [JsonPropertyName("is_created_from_ads_ui")]
    public bool IsCreatedFromAdsUi
    {
        get; set;
    }

    [JsonPropertyName("author_premium")]
    public bool AuthorPremium
    {
        get; set;
    }

    [JsonPropertyName("thumbnail")]
    public string Thumbnail
    {
        get; set;
    }

    [JsonPropertyName("edited")]
    public bool Edited
    {
        get; set;
    }

    [JsonPropertyName("author_flair_css_class")]
    public string AuthorFlairCssClass
    {
        get; set;
    }

    [JsonPropertyName("author_flair_richtext")]
    public List<object> AuthorFlairRichtext
    {
        get; set;
    }

    [JsonPropertyName("gildings")]
    public Gildings Gildings
    {
        get; set;
    }

    [JsonPropertyName("post_hint")]
    public string PostHint
    {
        get; set;
    }

    [JsonPropertyName("content_categories")]
    public object ContentCategories
    {
        get; set;
    }

    [JsonPropertyName("is_self")]
    public bool IsSelf
    {
        get; set;
    }

    [JsonPropertyName("mod_note")]
    public object ModNote
    {
        get; set;
    }

    [JsonPropertyName("created")]
    public double Created
    {
        get; set;
    }

    [JsonPropertyName("link_flair_type")]
    public string LinkFlairType
    {
        get; set;
    }

    [JsonPropertyName("wls")]
    public int Wls
    {
        get; set;
    }

    [JsonPropertyName("removed_by_category")]
    public object RemovedByCategory
    {
        get; set;
    }

    [JsonPropertyName("banned_by")]
    public object BannedBy
    {
        get; set;
    }

    [JsonPropertyName("author_flair_type")]
    public string AuthorFlairType
    {
        get; set;
    }

    [JsonPropertyName("domain")]
    public string Domain
    {
        get; set;
    }

    [JsonPropertyName("allow_live_comments")]
    public bool AllowLiveComments
    {
        get; set;
    }

    [JsonPropertyName("selftext_html")]
    public object SelftextHtml
    {
        get; set;
    }

    [JsonPropertyName("likes")]
    public object Likes
    {
        get; set;
    }

    [JsonPropertyName("suggested_sort")]
    public string SuggestedSort
    {
        get; set;
    }

    [JsonPropertyName("banned_at_utc")]
    public object BannedAtUtc
    {
        get; set;
    }

    [JsonPropertyName("url_overridden_by_dest")]
    public string UrlOverriddenByDest
    {
        get; set;
    }

    [JsonPropertyName("view_count")]
    public object ViewCount
    {
        get; set;
    }

    [JsonPropertyName("archived")]
    public bool Archived
    {
        get; set;
    }

    [JsonPropertyName("no_follow")]
    public bool NoFollow
    {
        get; set;
    }

    [JsonPropertyName("is_crosspostable")]
    public bool IsCrosspostable
    {
        get; set;
    }

    [JsonPropertyName("pinned")]
    public bool Pinned
    {
        get; set;
    }

    [JsonPropertyName("over_18")]
    public bool Over18
    {
        get; set;
    }

    [JsonPropertyName("preview")]
    public Preview Preview
    {
        get; set;
    }

    [JsonPropertyName("all_awardings")]
    public List<AllAwarding> AllAwardings
    {
        get; set;
    }

    [JsonPropertyName("awarders")]
    public List<object> Awarders
    {
        get; set;
    }

    [JsonPropertyName("media_only")]
    public bool MediaOnly
    {
        get; set;
    }

    [JsonPropertyName("can_gild")]
    public bool CanGild
    {
        get; set;
    }

    [JsonPropertyName("spoiler")]
    public bool Spoiler
    {
        get; set;
    }

    [JsonPropertyName("locked")]
    public bool Locked
    {
        get; set;
    }

    [JsonPropertyName("author_flair_text")]
    public string AuthorFlairText
    {
        get; set;
    }

    [JsonPropertyName("treatment_tags")]
    public List<object> TreatmentTags
    {
        get; set;
    }

    [JsonPropertyName("visited")]
    public bool Visited
    {
        get; set;
    }

    [JsonPropertyName("removed_by")]
    public object RemovedBy
    {
        get; set;
    }

    [JsonPropertyName("num_reports")]
    public object NumReports
    {
        get; set;
    }

    [JsonPropertyName("distinguished")]
    public object Distinguished
    {
        get; set;
    }

    [JsonPropertyName("subreddit_id")]
    public string SubredditId
    {
        get; set;
    }

    [JsonPropertyName("author_is_blocked")]
    public bool AuthorIsBlocked
    {
        get; set;
    }

    [JsonPropertyName("mod_reason_by")]
    public object ModReasonBy
    {
        get; set;
    }

    [JsonPropertyName("removal_reason")]
    public object RemovalReason
    {
        get; set;
    }

    [JsonPropertyName("link_flair_background_color")]
    public string LinkFlairBackgroundColor
    {
        get; set;
    }

    [JsonPropertyName("id")]
    public string Id
    {
        get; set;
    }

    [JsonPropertyName("is_robot_indexable")]
    public bool IsRobotIndexable
    {
        get; set;
    }

    [JsonPropertyName("report_reasons")]
    public object ReportReasons
    {
        get; set;
    }

    [JsonPropertyName("author")]
    public string Author
    {
        get; set;
    }

    [JsonPropertyName("discussion_type")]
    public object DiscussionType
    {
        get; set;
    }

    [JsonPropertyName("num_comments")]
    public int NumComments
    {
        get; set;
    }

    [JsonPropertyName("send_replies")]
    public bool SendReplies
    {
        get; set;
    }

    [JsonPropertyName("whitelist_status")]
    public string WhitelistStatus
    {
        get; set;
    }

    [JsonPropertyName("contest_mode")]
    public bool ContestMode
    {
        get; set;
    }

    [JsonPropertyName("mod_reports")]
    public List<object> ModReports
    {
        get; set;
    }

    [JsonPropertyName("author_patreon_flair")]
    public bool AuthorPatreonFlair
    {
        get; set;
    }

    [JsonPropertyName("author_flair_text_color")]
    public string AuthorFlairTextColor
    {
        get; set;
    }

    [JsonPropertyName("permalink")]
    public string Permalink
    {
        get; set;
    }

    [JsonPropertyName("parent_whitelist_status")]
    public string ParentWhitelistStatus
    {
        get; set;
    }

    [JsonPropertyName("stickied")]
    public bool Stickied
    {
        get; set;
    }

    [JsonPropertyName("url")]
    public string Url
    {
        get; set;
    }

    [JsonPropertyName("subreddit_subscribers")]
    public int SubredditSubscribers
    {
        get; set;
    }

    [JsonPropertyName("created_utc")]
    public double CreatedUtc
    {
        get; set;
    }

    [JsonPropertyName("num_crossposts")]
    public int NumCrossposts
    {
        get; set;
    }

    [JsonPropertyName("media")]
    public object Media
    {
        get; set;
    }

    [JsonPropertyName("is_video")]
    public bool IsVideo
    {
        get; set;
    }

    [JsonPropertyName("tournament_data")]
    public TournamentData TournamentData
    {
        get; set;
    }

    [JsonPropertyName("link_flair_template_id")]
    public string LinkFlairTemplateId
    {
        get; set;
    }
}

public class Gildings
{
    [JsonPropertyName("gid_1")]
    public int Gid1
    {
        get; set;
    }

    [JsonPropertyName("gid_2")]
    public int? Gid2
    {
        get; set;
    }
}

public class Image
{
    [JsonPropertyName("source")]
    public Source Source
    {
        get; set;
    }

    [JsonPropertyName("resolutions")]
    public List<Resolution> Resolutions
    {
        get; set;
    }

    [JsonPropertyName("variants")]
    public Variants Variants
    {
        get; set;
    }

    [JsonPropertyName("id")]
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
    [JsonPropertyName("total_amount")]
    public int TotalAmount
    {
        get; set;
    }

    [JsonPropertyName("text")]
    public string Text
    {
        get; set;
    }

    [JsonPropertyName("vote_count")]
    public int VoteCount
    {
        get; set;
    }

    [JsonPropertyName("user_amount")]
    public object UserAmount
    {
        get; set;
    }

    [JsonPropertyName("image_url")]
    public object ImageUrl
    {
        get; set;
    }

    [JsonPropertyName("id")]
    public string Id
    {
        get; set;
    }
}

public class Prediction
{
    [JsonPropertyName("status")]
    public string Status
    {
        get; set;
    }

    [JsonPropertyName("body")]
    public string Body
    {
        get; set;
    }

    [JsonPropertyName("is_rtjson")]
    public bool IsRtjson
    {
        get; set;
    }

    [JsonPropertyName("is_nsfw")]
    public bool IsNsfw
    {
        get; set;
    }

    [JsonPropertyName("title")]
    public string Title
    {
        get; set;
    }

    [JsonPropertyName("created_at")]
    public object CreatedAt
    {
        get; set;
    }

    [JsonPropertyName("voting_end_timestamp")]
    public object VotingEndTimestamp
    {
        get; set;
    }

    [JsonPropertyName("id")]
    public string Id
    {
        get; set;
    }

    [JsonPropertyName("vote_updates_remained")]
    public object VoteUpdatesRemained
    {
        get; set;
    }

    [JsonPropertyName("resolved_option_id")]
    public string ResolvedOptionId
    {
        get; set;
    }

    [JsonPropertyName("user_won_amount")]
    public object UserWonAmount
    {
        get; set;
    }

    [JsonPropertyName("is_spoiler")]
    public bool IsSpoiler
    {
        get; set;
    }

    [JsonPropertyName("user_selection")]
    public object UserSelection
    {
        get; set;
    }

    [JsonPropertyName("options")]
    public List<Option> Options
    {
        get; set;
    }

    [JsonPropertyName("total_stake_amount")]
    public int TotalStakeAmount
    {
        get; set;
    }

    [JsonPropertyName("total_vote_count")]
    public int TotalVoteCount
    {
        get; set;
    }
}

public class Preview
{
    [JsonPropertyName("images")]
    public List<Image> Images
    {
        get; set;
    }

    [JsonPropertyName("enabled")]
    public bool Enabled
    {
        get; set;
    }
}

public class ResizedIcon
{
    [JsonPropertyName("url")]
    public string Url
    {
        get; set;
    }

    [JsonPropertyName("width")]
    public int Width
    {
        get; set;
    }

    [JsonPropertyName("height")]
    public int Height
    {
        get; set;
    }
}

public class ResizedStaticIcon
{
    [JsonPropertyName("url")]
    public string Url
    {
        get; set;
    }

    [JsonPropertyName("width")]
    public int Width
    {
        get; set;
    }

    [JsonPropertyName("height")]
    public int Height
    {
        get; set;
    }
}

public class Resolution
{
    [JsonPropertyName("url")]
    public string Url
    {
        get; set;
    }

    [JsonPropertyName("width")]
    public int Width
    {
        get; set;
    }

    [JsonPropertyName("height")]
    public int Height
    {
        get; set;
    }
}

public class Root
{
    [JsonPropertyName("kind")]
    public string Kind
    {
        get; set;
    }

    [JsonPropertyName("data")]
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
    [JsonPropertyName("url")]
    public string Url
    {
        get; set;
    }

    [JsonPropertyName("width")]
    public int Width
    {
        get; set;
    }

    [JsonPropertyName("height")]
    public int Height
    {
        get; set;
    }
}

public class TournamentData
{
    [JsonPropertyName("status")]
    public string Status
    {
        get; set;
    }

    [JsonPropertyName("total_participants")]
    public int TotalParticipants
    {
        get; set;
    }

    [JsonPropertyName("subreddit_id")]
    public string SubredditId
    {
        get; set;
    }

    [JsonPropertyName("name")]
    public string Name
    {
        get; set;
    }

    [JsonPropertyName("predictions")]
    public List<Prediction> Predictions
    {
        get; set;
    }

    [JsonPropertyName("currency")]
    public string Currency
    {
        get; set;
    }

    [JsonPropertyName("theme_id")]
    public string ThemeId
    {
        get; set;
    }

    [JsonPropertyName("tournament_id")]
    public string TournamentId
    {
        get; set;
    }
}

public class Variants
{
}

