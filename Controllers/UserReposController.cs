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
                HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                        string data = await response.Content.ReadAsStringAsync();
                        // Process the data or return it as-is
                        return Ok(data);
                }
                else
                {
                        return StatusCode((int)response.StatusCode);
                }
                
        }
        
}