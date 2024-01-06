namespace github_fetcher_api_dotnet.Models;

public class Repos
{
    public Repos () { }

    public Repos (GetUserRepos userRepos)
    {
        this.Name = userRepos.Name;
        this.Description = userRepos.Description;
        this.Url = userRepos.Url;
    }
    public string Name { get; set;} 
    public string Description { get; set;}
    public string Url { get; set;}


}
public class GetUserRepos : Repos
{
    public int Id { get; set;}
    public string NodeId { get; set;}
    public string FullName { get; set;}
    public bool Private { get; set;}
    public User Owner { get; set;}
    public string HtmlUrl { get; set;}
    public bool Fork { get; set;}
    public string ForksUrl { get; set;}
    public string KeysUrl { get; set;}
    public string CollaboratorsUrl { get; set;}
    public string TeamsUrl { get; set;}
    public string HooksUrl { get; set;}
    public string IssueEventsUrl { get; set;}
    public string EventsUrl { get; set;}
    public string AssigneesUrl { get; set;}
    public string BranchesUrl { get; set;}
    public string TagsUrl { get; set;}
    public string BlobsUrl { get; set;}
    public string GitTagsUrl { get; set;}
    public string GitRefsUrl { get; set;}
    public string TreesUrl { get; set;}
    public string StatusesUrl { get; set;}
    public string LanguagesUrl { get; set;}
    public string StargazersUrl { get; set;}
    public string ContributorsUrl { get; set;}
    public string SubscribersUrl { get; set;}
    public string SubscriptionUrl { get; set;}
    public string CommitsUrl { get; set;}
    public string GitCommitsUrl { get; set;}
    public string CommentsUrl { get; set;}
    public string IssueCommentUrl { get; set;}
    public string ContentsUrl { get; set;}
    public string CompareUrl { get; set;}
    public string MergesUrl { get; set;}
    public string ArchiveUrl { get; set;}
    public string DownloadsUrl { get; set;}
    public string IssuesUrl { get; set;}
    public string PullsUrl { get; set;}
    public string MilestonesUrl { get; set;}
    public string NotificationsUrl { get; set;}
    public string LabelsUrl { get; set;}
    public string ReleasesUrl { get; set;}
    public string DeploymentsUrl { get; set;}
    public DateTime CreatedAt { get; set;}
    public DateTime UpdatedAt { get; set;}
    public DateTime PushedAt { get; set;}
    public string GitUrl { get; set;}
    public string SshUrl { get; set;}
    public string CloneUrl { get; set;}
    public string SvnUrl { get; set;}
    public string Homepage { get; set;}
    public int Size { get; set;}
    public int StargazersCount { get; set;}
    public int WatchersCount { get; set;}
    public string Language { get; set;}
    public bool HasIssues { get; set;}
    public bool HasProjects { get; set;}
    public bool HasDownloads { get; set;}
    public bool HasWiki { get; set;}
    public bool HasPages { get; set;}
    public bool HasDiscussions { get; set;}
    public int ForksCount { get; set;}
    public string MirrorUrl { get; set;}
    public bool Archived { get; set;}
    public bool Disabled { get; set;}
    public int OpenIssuesCount { get; set;}
    public RepoLicense License { get; set;}
    public bool AllowForking { get; set;}
    public bool IsTemplate { get; set;}
    public bool WebCommitSignoffRequired { get; set;}
    public string[] Topics { get; set;}
    public string Visibility { get; set;}
    public int Forks { get; set;}
    public int OpenIssues { get; set;}
    public int Watchers { get; set;}
    public string DefaultBranch { get; set;}

    public GetUserRepos(int id, string nodeId, string name, string fullName, bool @private, User owner, string htmlUrl, string description, bool fork, string url, string forksUrl, string keysUrl, string collaboratorsUrl, string teamsUrl, string hooksUrl, string issueEventsUrl, string eventsUrl, string assigneesUrl, string branchesUrl, string tagsUrl, string blobsUrl, string gitTagsUrl, string gitRefsUrl, string treesUrl, string statusesUrl, string languagesUrl, string stargazersUrl, string contributorsUrl, string subscribersUrl, string subscriptionUrl, string commitsUrl, string gitCommitsUrl, string commentsUrl, string issueCommentUrl, string contentsUrl, string compareUrl, string mergesUrl, string archiveUrl, string downloadsUrl, string issuesUrl, string pullsUrl, string milestonesUrl, string notificationsUrl, string labelsUrl, string releasesUrl, string deploymentsUrl, DateTime createdAt, DateTime updatedAt, DateTime pushedAt, string gitUrl, string sshUrl, string cloneUrl, string svnUrl, string homepage, int size, int stargazersCount, int watchersCount, string language, bool hasIssues, bool hasProjects, bool hasDownloads, bool hasWiki, bool hasPages, bool hasDiscussions, int forksCount, string mirrorUrl, bool archived, bool disabled, int openIssuesCount, RepoLicense license, bool allowForking, bool isTemplate, bool webCommitSignoffRequired, string[] topics, string visibility, int forks, int openIssues, int watchers, string defaultBranch)
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
    public string Login { get; set;}
    public int Id { get; set;}
    public string NodeId { get; set;}
    public string AvatarUrl { get; set;}
    public string GravatarId { get; set;}
    public string Url { get; set;}
    public string HtmlUrl { get; set;}
    public string FollowersUrl { get; set;}
    public string FollowingUrl { get; set;}
    public string GistsUrl { get; set;}
    public string StarredUrl { get; set;}
    public string SubscriptionsUrl { get; set;}
    public string OrganizationsUrl { get; set;}
    public string ReposUrl { get; set;}
    public string EventsUrl { get; set;}
    public string ReceivedEventsUrl { get; set;}
    public string Type { get; set;}
    public bool SiteAdmin { get; set;}

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

public class RepoLicense
{
    public string Key { get; set;}
    public string Name { get; set;}
    public string Url { get; set;}
    public string Spdx_id { get; set;}
    public string Node_id { get; set;}
    public string Html_url { get; set;}
    public RepoLicense(string key, string name, string url, string spdx_id, string node_id, string html_url)
    {
        Key = key;
        Name = name;
        Url = url;
        Spdx_id = spdx_id;
        Node_id = node_id;
        Html_url = html_url;
    }
}
