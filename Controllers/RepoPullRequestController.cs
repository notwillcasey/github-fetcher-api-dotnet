using github_fetcher_api_dotnet.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace github_fetcher_api_dotnet.Controllers;

[ApiController]
[Route("[controller]")]
public class RepoPullRequestController : ControllerBase
{
    private readonly HttpClient _httpClient;

    public RepoPullRequestController()
    {
        _httpClient = new HttpClient();
    }
    
    [HttpGet("{user}")]
    public async Task<IActionResult> GetRepoPullRequest(string user, string repo)
    {
        var apiUrl = $"https://api.github.com/repos/{user}/{repo}/pulls";
        _httpClient.DefaultRequestHeaders.Add("Accept", "application/vnd.github+json");
        _httpClient.DefaultRequestHeaders.Add("User-Agent", "Request");
        _httpClient.DefaultRequestHeaders.Add("token", "token");
        HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);
                
        if (response.IsSuccessStatusCode)
        {
            string data = response.Content.ReadAsStringAsync().Result;
            GetRepoPullRequest userProfile = JsonConvert.DeserializeObject<GetRepoPullRequest>(data);
            return Ok(userProfile);
        }
        else
        {
            return StatusCode((int)response.StatusCode);
        }
    }
}