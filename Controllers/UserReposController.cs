using System.Net.Http.Headers;
using github_fetcher_api_dotnet.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace github_fetcher_api_dotnet.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserReposController : ControllerBase
{
        private readonly HttpClient _httpClient;

        public UserReposController()
        {
                _httpClient = new HttpClient();
        }
        
        [HttpGet("{user}")]
        public async Task<IActionResult> GetUserRepos(string user)
        {
                var apiUrl = $"https://api.github.com/users/{user}/repos";
                _httpClient.DefaultRequestHeaders.Add("Accept", "application/vnd.github+json");
                _httpClient.DefaultRequestHeaders.Add("User-Agent", "Request");
                _httpClient.DefaultRequestHeaders.Add("token", "token");
                HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);
                
                if (response.IsSuccessStatusCode)
                {
                        string data = response.Content.ReadAsStringAsync().Result;
                        List<GetUserRepos> userRepos = JsonConvert.DeserializeObject<List<GetUserRepos>>(data);
                        List<Repos> repos = new List<Repos>();
                        foreach (var el in userRepos)
                        {
                                Repos repo = new Repos(el);
                                repos.Add(repo);
                        }
                        return Ok(repos);
                }
                else
                {
                        return StatusCode((int)response.StatusCode);
                }
        }
}