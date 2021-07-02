using Microsoft.AspNetCore.Mvc;
using Moduit.Interview.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Moduit.Interview.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionOneController : ControllerBase
    {
        private static readonly HttpClient client = new HttpClient();
        // GET: api/<QuestionOneController>
        [HttpGet]
        public async Task<QuestionModel> Get()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            var streamTask = client.GetStreamAsync("https://screening.moduit.id/backend/question/one");
            var endPoints = await JsonSerializer.DeserializeAsync<QuestionModel>(await streamTask);

            return endPoints;
        }
    }
}
