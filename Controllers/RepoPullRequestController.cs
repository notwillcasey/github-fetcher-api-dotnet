using System.Net.Http.Headers;
using github_fetcher_api_dotnet.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace github_fetcher_api_dotnet.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RepoPullRequestController : ControllerBase
{
    private readonly HttpClient _httpClient;

    public RepoPullRequestController()
    {
        _httpClient = new HttpClient();
    }
    
    [HttpGet("{user}/{repo}")]
    public async Task<IActionResult> GetRepoPullRequest(string user, string repo)
    {
        var apiUrl = $"https://api.github.com/repos/{user}/{repo}/pulls";
        _httpClient.DefaultRequestHeaders.Add("Accept", "application/vnd.github+json");
        _httpClient.DefaultRequestHeaders.Add("User-Agent", "Request");
        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Token", "token");
        HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);
        
        if (response.IsSuccessStatusCode)
        {
            string data = response.Content.ReadAsStringAsync().Result;
            List<GetRepoPullRequests> userPullRequests = JsonConvert.DeserializeObject<List<GetRepoPullRequests>>(data);
            return Ok(userPullRequests);
        }
        else
        {
            return StatusCode((int)response.StatusCode);
        }
    }
}