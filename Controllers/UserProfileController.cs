using github_fetcher_api_dotnet.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace github_fetcher_api_dotnet.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserProfileController : ControllerBase
{
    private readonly HttpClient _httpClient;

    public UserProfileController()
    {
        _httpClient = new HttpClient();
    }
    
    [HttpGet("{user}")]
    public async Task<IActionResult> GetUserProfile(string user)
    {
        var apiUrl = $"https://api.github.com/users/{user}";
        _httpClient.DefaultRequestHeaders.Add("Accept", "application/vnd.github+json");
        _httpClient.DefaultRequestHeaders.Add("User-Agent", "Request");
        _httpClient.DefaultRequestHeaders.Add("token", "token");
        HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);
                
        if (response.IsSuccessStatusCode)
        {
            string data = response.Content.ReadAsStringAsync().Result;
            GetUserProfile userProfile = JsonConvert.DeserializeObject<GetUserProfile>(data);
            return Ok(userProfile);
        }
        else
        {
            return StatusCode((int)response.StatusCode);
        }
    }
}