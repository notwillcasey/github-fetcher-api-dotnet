namespace github_fetcher_api_dotnet.Models;

public class UserRepos
{
    public int Id { get; }
    public string NodeId { get; }
    public string Name { get; }
    public string FullName { get; }
    public bool Private { get; }
    public User Owner { get; }
    public string HtmlUrl { get; }
    public string Description { get; }
    public bool Fork { get; }
    public string Url { get; }
    public string ForksUrl { get; }
    public string KeysUrl { get; }
    public string CollaboratorsUrl { get; }
    public string TeamsUrl { get; }
    public string HooksUrl { get; }
    public string IssueEventsUrl { get; }
    public string EventsUrl { get; }
    public string AssigneesUrl { get; }
    public string BranchesUrl { get; }
    public string TagsUrl { get; }
    public string BlobsUrl { get; }
    public string GitTagsUrl { get; }
    public string GitRefsUrl { get; }
    public string TreesUrl { get; }
    public string StatusesUrl { get; }
    public string LanguagesUrl { get; }
    public string StargazersUrl { get; }
    public string ContributorsUrl { get; }
    public string SubscribersUrl { get; }
    public string SubscriptionUrl { get; }
    public string CommitsUrl { get; }
    public string GitCommitsUrl { get; }
    public string CommentsUrl { get; }
    public string IssueCommentUrl { get; }
    public string ContentsUrl { get; }
    public string CompareUrl { get; }
    public string MergesUrl { get; }
    public string ArchiveUrl { get; }
    public string DownloadsUrl { get; }
    public string IssuesUrl { get; }
    public string PullsUrl { get; }
    public string MilestonesUrl { get; }
    public string NotificationsUrl { get; }
    public string LabelsUrl { get; }
    public string ReleasesUrl { get; }
    public string DeploymentsUrl { get; }
    public DateTime CreatedAt { get; }
    public DateTime UpdatedAt { get; }
    public DateTime PushedAt { get; }
    public string GitUrl { get; }
    public string SshUrl { get; }
    public string CloneUrl { get; }
    public string SvnUrl { get; }
    public string Homepage { get; }
    public int Size { get; }
    public int StargazersCount { get; }
    public int WatchersCount { get; }
    public string Language { get; }
    public bool HasIssues { get; }
    public bool HasProjects { get; }
    public bool HasDownloads { get; }
    public bool HasWiki { get; }
    public bool HasPages { get; }
    public bool HasDiscussions { get; }
    public int ForksCount { get; }
    public string MirrorUrl { get; }
    public bool Archived { get; }
    public bool Disabled { get; }
    public int OpenIssuesCount { get; }
    public string License { get; }
    public bool AllowForking { get; }
    public bool IsTemplate { get; }
    public bool WebCommitSignoffRequired { get; }
    public string[] Topics { get; }
    public string Visibility { get; }
    public int Forks { get; }
    public int OpenIssues { get; }
    public int Watchers { get; }
    public string DefaultBranch { get; }

    public UserRepos(int id, string nodeId, string name, string fullName, bool @private, User owner, string htmlUrl, string description, bool fork, string url, string forksUrl, string keysUrl, string collaboratorsUrl, string teamsUrl, string hooksUrl, string issueEventsUrl, string eventsUrl, string assigneesUrl, string branchesUrl, string tagsUrl, string blobsUrl, string gitTagsUrl, string gitRefsUrl, string treesUrl, string statusesUrl, string languagesUrl, string stargazersUrl, string contributorsUrl, string subscribersUrl, string subscriptionUrl, string commitsUrl, string gitCommitsUrl, string commentsUrl, string issueCommentUrl, string contentsUrl, string compareUrl, string mergesUrl, string archiveUrl, string downloadsUrl, string issuesUrl, string pullsUrl, string milestonesUrl, string notificationsUrl, string labelsUrl, string releasesUrl, string deploymentsUrl, DateTime createdAt, DateTime updatedAt, DateTime pushedAt, string gitUrl, string sshUrl, string cloneUrl, string svnUrl, string homepage, int size, int stargazersCount, int watchersCount, string language, bool hasIssues, bool hasProjects, bool hasDownloads, bool hasWiki, bool hasPages, bool hasDiscussions, int forksCount, string mirrorUrl, bool archived, bool disabled, int openIssuesCount, string license, bool allowForking, bool isTemplate, bool webCommitSignoffRequired, string[] topics, string visibility, int forks, int openIssues, int watchers, string defaultBranch)
    {
        // allows us to enforce any parameters around each value
        Id = id;
        NodeId = nodeId;
        Name = name;
        FullName = fullName;
        Private = @private;
        Owner = owner;
        HtmlUrl = htmlUrl;
        Description = description;
        Fork = fork;
        Url = url;
        ForksUrl = forksUrl;
        KeysUrl = keysUrl;
        CollaboratorsUrl = collaboratorsUrl;
        TeamsUrl = teamsUrl;
        HooksUrl = hooksUrl;
        IssueEventsUrl = issueEventsUrl;
        EventsUrl = eventsUrl;
        AssigneesUrl = assigneesUrl;
        BranchesUrl = branchesUrl;
        TagsUrl = tagsUrl;
        BlobsUrl = blobsUrl;
        GitTagsUrl = gitTagsUrl;
        GitRefsUrl = gitRefsUrl;
        TreesUrl = treesUrl;
        StatusesUrl = statusesUrl;
        LanguagesUrl = languagesUrl;
        StargazersUrl = stargazersUrl;
        ContributorsUrl = contributorsUrl;
        SubscribersUrl = subscribersUrl;
        SubscriptionUrl = subscriptionUrl;
        CommitsUrl = commitsUrl;
        GitCommitsUrl = gitCommitsUrl;
        CommentsUrl = commentsUrl;
        IssueCommentUrl = issueCommentUrl;
        ContentsUrl = contentsUrl;
        CompareUrl = compareUrl;
        MergesUrl = mergesUrl;
        ArchiveUrl = archiveUrl;
        DownloadsUrl = downloadsUrl;
        IssuesUrl = issuesUrl;
        PullsUrl = pullsUrl;
        MilestonesUrl = milestonesUrl;
        NotificationsUrl = notificationsUrl;
        LabelsUrl = labelsUrl;
        ReleasesUrl = releasesUrl;
        DeploymentsUrl = deploymentsUrl;
        CreatedAt = createdAt;
        UpdatedAt = updatedAt;
        PushedAt = pushedAt;
        GitUrl = gitUrl;
        SshUrl = sshUrl;
        CloneUrl = cloneUrl;
        SvnUrl = svnUrl;
        Homepage = homepage;
        Size = size;
        StargazersCount = stargazersCount;
        WatchersCount = watchersCount;
        Language = language;
        HasIssues = hasIssues;
        HasProjects = hasProjects;
        HasDownloads = hasDownloads;
        HasWiki = hasWiki;
        HasPages = hasPages;
        HasDiscussions = hasDiscussions;
        ForksCount = forksCount;
        MirrorUrl = mirrorUrl;
        Archived = archived;
        Disabled = disabled;
        OpenIssuesCount = openIssuesCount;
        License = license;
        AllowForking = allowForking;
        IsTemplate = isTemplate;
        WebCommitSignoffRequired = webCommitSignoffRequired;
        Topics = topics;
        Visibility = visibility;
        Forks = forks;
        OpenIssues = openIssues;
        Watchers = watchers;
        DefaultBranch = defaultBranch;
    }
}

public class User
{
    public string Login { get; }
    public int Id { get; }
    public string NodeId { get; }
    public string AvatarUrl { get; }
    public string GravatarId { get; }
    public string Url { get; }
    public string HtmlUrl { get; }
    public string FollowersUrl { get; }
    public string FollowingUrl { get; }
    public string GistsUrl { get; }
    public string StarredUrl { get; }
    public string SubscriptionsUrl { get; }
    public string OrganizationsUrl { get; }
    public string ReposUrl { get; }
    public string EventsUrl { get; }
    public string ReceivedEventsUrl { get; }
    public string Type { get; }
    public bool SiteAdmin { get; }

    public User(string login, int id, string nodeId, string avatarUrl, string gravatarId, string url, string htmlUrl, string followersUrl, string followingUrl, string gistsUrl, string starredUrl, string subscriptionsUrl, string organizationsUrl, string reposUrl, string eventsUrl, string receivedEventsUrl, string type, bool siteAdmin)
    {
        // allows us to enforce any parameters around each value
        Login = login;
        Id = id;
        NodeId = nodeId;
        AvatarUrl = avatarUrl;
        GravatarId = gravatarId;
        Url = url;
        HtmlUrl = htmlUrl;
        FollowersUrl = followersUrl;
        FollowingUrl = followingUrl;
        GistsUrl = gistsUrl;
        StarredUrl = starredUrl;
        SubscriptionsUrl = subscriptionsUrl;
        OrganizationsUrl = organizationsUrl;
        ReposUrl = reposUrl;
        EventsUrl = eventsUrl;
        ReceivedEventsUrl = receivedEventsUrl;
        Type = type;
        SiteAdmin = siteAdmin;
    }
}