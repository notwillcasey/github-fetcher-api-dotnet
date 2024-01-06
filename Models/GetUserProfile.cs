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
    
    public GetUserProfile(string login, int id, string nodeId, string avatarUrl, string gravatarId, string url, string htmlUrl, string followersUrl, string followingUrl, string gistsUrl, string starredUrl, string subscriptionsUrl, string organizationsUrl, string reposUrl, string eventsUrl, string receivedEventsUrl, string type, bool siteAdmin, string name, string company, string blog, string location, string email, bool? hireable, string bio, string twitterUsername, int publicRepos, int publicGists, int followers, int following, DateTime createdAt, DateTime updatedAt)
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
        SubscriptionsUrl = subscriptionsUrl;
        OrganizationsUrl = organizationsUrl;
        ReposUrl = reposUrl;
        EventsUrl = eventsUrl;
        ReceivedEventsUrl = receivedEventsUrl;
        Type = type;
        SiteAdmin = siteAdmin;
        Name = name;
        Company = company;
        Blog = blog;
        Location = location;
        Email = email;
        Hireable = hireable;
        Bio = bio;
        TwitterUsername = twitterUsername;
        PublicRepos = publicRepos;
        PublicGists = publicGists;
        Followers = followers;
        Following = following;
        CreatedAt = createdAt;
        UpdatedAt = updatedAt;
    }

}