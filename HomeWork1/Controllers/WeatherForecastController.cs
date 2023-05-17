using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;

namespace HomeWork1.Controllers
{
    [ApiController]
    [Route("home/index")]
    public class PostController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public PostController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpPost]
        public async Task<IActionResult> Post()
        {
            var formData = await Request.ReadFormAsync();
            var formValues = formData.ToDictionary(x => x.Key, x => x.Value.ToString());

            string redirectedUrl = "https://processing.hgg-pay.kz/home/index";

            var httpClient = _httpClientFactory.CreateClient();
            var response = await httpClient.PostAsync(redirectedUrl, new FormUrlEncodedContent(formValues));
            var responseContent = await response.Content.ReadAsStringAsync();

            return Content(responseContent, "application/json", Encoding.UTF8);
        }
    }
}