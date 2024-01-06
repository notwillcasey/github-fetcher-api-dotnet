using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;

namespace github_fetcher_api_dotnet.Controllers;

[ApiController]
[Route("[controller]")]
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
                _httpClient.DefaultRequestHeaders.Add("token", "TOKEN");
                HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);
                
                if (response.IsSuccessStatusCode)
                {
                        string data = await response.Content.ReadAsStringAsync();
                        return Ok(data);
                }
                else
                {
                        return StatusCode((int)response.StatusCode);
                }



                
        }
        
}