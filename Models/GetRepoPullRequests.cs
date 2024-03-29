﻿namespace github_fetcher_api_dotnet.Models;

public class PrUser
{
    public PrUser(string login, int id, string nodeId, string avatarUrl, string gravatarId, string url, string htmlUrl, string followersUrl, string followingUrl, string gistsUrl, string starredUrl, string subscriptionUrl, string organizationUrl, string reposUrl, string eventsUrl, string receivedEventsUrl, string type, bool siteAdmin)
    {
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
        SubscriptionUrl = subscriptionUrl;
        OrganizationUrl = organizationUrl;
        ReposUrl = reposUrl;
        EventsUrl = eventsUrl;
        ReceivedEventsUrl = receivedEventsUrl;
        Type = type;
        SiteAdmin = siteAdmin;
    }

    public string Login { get; set; }
    public int Id { get; set; }
    public string NodeId { get; set; }
    public string AvatarUrl { get; set; }
    public string GravatarId { get; set; }
    public string Url { get; set; }
    public string HtmlUrl { get; set; }
    public string FollowersUrl { get; set; }
    public string FollowingUrl { get; set; }
    public string GistsUrl { get; set; }
    public string StarredUrl { get; set; }
    public string SubscriptionUrl { get; set; }
    public string OrganizationUrl { get; set; }
    public string ReposUrl { get; set; }
    public string EventsUrl { get; set; }
    public string ReceivedEventsUrl { get; set; }
    public string Type { get; set; }
    public bool SiteAdmin { get; set; }
    // Add other properties as needed
}

public class Label
{
    public Label(int id, string nodeId, string url, string name, string description, string color, bool @default)
    {
        Id = id;
        NodeId = nodeId;
        Url = url;
        Name = name;
        Description = description;
        Color = color;
        Default = @default;
    }

    public int Id { get; set; }
    public string NodeId { get; set; }
    public string Url { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Color { get; set; }
    public bool Default { get; set; }
    // Add other properties as needed
}

public class Milestone
{
    public string Url { get; set; }
    public string HtmlUrl { get; set; }
    public string LabelsUrl { get; set; }
    public int Id { get; set; }
    public string NodeId { get; set; }
    public int Number { get; set; }
    public string State { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public PrUser Creator { get; set; }
    public int OpenIssues { get; set; }
    public int ClosedIssues { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? ClosedAt { get; set; }
    public DateTime DueOn { get; set; }
    // Add other properties as needed
}

public class Head
{
    public string Label { get; set; }
    public string Ref { get; set; }
    public string Sha { get; set; }
    public PrUser User { get; set; }
    public Repo Repo { get; set; }
}

public class Repo
{
    // Represents the "repo" property in the "head" object
    public int Id { get; set; }
    public string NodeId { get; set; }
    public string Name { get; set; }
    public string FullName { get; set; }
    public PrUser Owner { get; set; }
    public bool Private { get; set; }
    public string HtmlUrl { get; set; }
    public string Description { get; set; }
    // Add other properties as needed
}

public class Base
{
    public string Label { get; set; }
    public string Ref { get; set; }
    public string Sha { get; set; }
    public PrUser User { get; set; }
    public Repo Repo { get; set; }
}

public class RequestedReviewers
{
    public string Login { get; set; }
    public int Id { get; set; }
    public string NodeId { get; set; }
    public string AvatarUrl { get; set; }
    public string GravatarId { get; set; }
    public string Url { get; set; }
    public string HtmlUrl { get; set; }
    // Add other properties as needed
}

public class GetRepoPullRequests
{
    public string Url { get; set; }
    public int Id { get; set; }
    public string NodeId { get; set; }
    public string HtmlUrl { get; set; }
    public string DiffUrl { get; set; }
    public string PatchUrl { get; set; }
    public string IssueUrl { get; set; }
    public string CommitsUrl { get; set; }
    public string ReviewCommentsUrl { get; set; }
    public string ReviewCommentUrl { get; set; }
    public string CommentsUrl { get; set; }
    public string StatusesUrl { get; set; }
    public int Number { get; set; }
    public string State { get; set; }
    public bool Locked { get; set; }
    public string Title { get; set; }
    public PrUser User { get; set; }
    public string Body { get; set; }
    public List<Label> Labels { get; set; }
    public Milestone Milestone { get; set; } // should contain creator
    public string ActiveLockReason { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? ClosedAt { get; set; }
    public DateTime? MergedAt { get; set; }
    public string MergeCommitSha { get; set; }
    public PrUser Assignee { get; set; }
    public List<PrUser> Assignees { get; set; }
    public List<RequestedReviewers> RequestedReviewers { get; set; }
    public List<RequestedTeam> RequestedTeams { get; set; }
    // Add other properties as needed
    
    public GetRepoPullRequests(string url, int id, string nodeId, string htmlUrl, string diffUrl, string patchUrl, string issueUrl, string commitsUrl, string reviewCommentsUrl, string reviewCommentUrl, string commentsUrl, string statusesUrl, int number, string state, bool locked, string title, PrUser user, string body, List<Label> labels, Milestone milestone, string activeLockReason, DateTime createdAt, DateTime updatedAt, DateTime? closedAt, DateTime? mergedAt, string mergeCommitSha, PrUser assignee, List<PrUser> assignees, List<RequestedReviewers> requestedReviewers, List<RequestedTeam> requestedTeams)
    {
        Url = url;
        Id = id;
        NodeId = nodeId;
        HtmlUrl = htmlUrl;
        DiffUrl = diffUrl;
        PatchUrl = patchUrl;
        IssueUrl = issueUrl;
        CommitsUrl = commitsUrl;
        ReviewCommentsUrl = reviewCommentsUrl;
        ReviewCommentUrl = reviewCommentUrl;
        CommentsUrl = commentsUrl;
        StatusesUrl = statusesUrl;
        Number = number;
        State = state;
        Locked = locked;
        Title = title;
        User = user;
        Body = body;
        Labels = labels;
        Milestone = milestone;
        ActiveLockReason = activeLockReason;
        CreatedAt = createdAt;
        UpdatedAt = updatedAt;
        ClosedAt = closedAt;
        MergedAt = mergedAt;
        MergeCommitSha = mergeCommitSha;
        Assignee = assignee;
        Assignees = assignees;
        RequestedReviewers = requestedReviewers;
        RequestedTeams = requestedTeams;
    }
}

public class RequestedTeam
{
    public RequestedTeam(int id, string nodeId, string url, string htmlUrl, string name, string slug, string description, string privacy, string permission, string notificationSetting, string membersUrl, string repositoriesUrl, object parent)
    {
        Id = id;
        NodeId = nodeId;
        Url = url;
        HtmlUrl = htmlUrl;
        Name = name;
        Slug = slug;
        Description = description;
        Privacy = privacy;
        Permission = permission;
        NotificationSetting = notificationSetting;
        MembersUrl = membersUrl;
        RepositoriesUrl = repositoriesUrl;
        Parent = parent;
    }

    public int Id { get; set; }
    public string NodeId { get; set; }
    public string Url { get; set; }
    public string HtmlUrl { get; set; }
    public string Name { get; set; }
    public string Slug { get; set; }
    public string Description { get; set; }
    public string Privacy { get; set; }
    public string Permission { get; set; }
    public string NotificationSetting { get; set; }
    public string MembersUrl { get; set; }
    public string RepositoriesUrl { get; set; }
    public object Parent { get; set; }
}