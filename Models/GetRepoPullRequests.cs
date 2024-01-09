namespace github_fetcher_api_dotnet.Models;

public class PrUser
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

public class Label
{
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

public class GetRepoPullRequest
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
    public Milestone Milestone { get; set; }
    public string ActiveLockReason { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? ClosedAt { get; set; }
    public DateTime? MergedAt { get; set; }
    public string MergeCommitSha { get; set; }
    public PrUser Assignee { get; set; }
    public List<PrUser> Assignees { get; set; }
    public List<RequestedReviewers> RequestedReviewers { get; set; }
    // Add other properties as needed
}