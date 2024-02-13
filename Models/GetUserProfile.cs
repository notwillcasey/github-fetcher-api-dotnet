namespace github_fetcher_api_dotnet.Models;

public class GetUserProfile
{
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
    public string SubscriptionsUrl { get; set; }
    public string OrganizationsUrl { get; set; }
    public string ReposUrl { get; set; }
    public string EventsUrl { get; set; }
    public string ReceivedEventsUrl { get; set; }
    public string Type { get; set; }
    public bool SiteAdmin { get; set; }
    public string Name { get; set; }
    public string Company { get; set; }
    public string Blog { get; set; }
    public string Location { get; set; }
    public string Email { get; set; }
    public bool? Hireable { get; set; }
    public string Bio { get; set; }
    public string TwitterUsername { get; set; }
    public int PublicRepos { get; set; }
    public int PublicGists { get; set; }
    public int Followers { get; set; }
    public int Following { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    
    public GetUserProfile(string login, int id, string nodeId, string avatar_url, string gravatarId, string url, string html_url, string followers_url, string following_url, string gists_url, string starred_url, string subscriptions_url, string organizations_url, string repos_url, string events_url, string received_events_url, string type, bool site_admin, string name, string company, string blog, string location, string email, bool? hireable, string bio, string twitter_username, int public_repos, int public_gists, int followers, int following, DateTime created_at, DateTime updated_at)
    {
        Login = login;
        Id = id;
        NodeId = nodeId;
        AvatarUrl = avatar_url;
        GravatarId = gravatarId;
        Url = url;
        HtmlUrl = html_url;
        FollowersUrl = followers_url;
        FollowingUrl = following_url;
        GistsUrl = gists_url;
        StarredUrl = starred_url;
        SubscriptionsUrl = subscriptions_url;
        OrganizationsUrl = organizations_url;
        ReposUrl = repos_url;
        EventsUrl = events_url;
        ReceivedEventsUrl = received_events_url;
        Type = type;
        SiteAdmin = site_admin;
        Name = name;
        Company = company;
        Blog = blog;
        Location = location;
        Email = email;
        Hireable = hireable;
        Bio = bio;
        TwitterUsername = twitter_username;
        PublicRepos = public_repos;
        PublicGists = public_gists;
        Followers = followers;
        Following = following;
        CreatedAt = created_at;
        UpdatedAt = updated_at;
    }

}