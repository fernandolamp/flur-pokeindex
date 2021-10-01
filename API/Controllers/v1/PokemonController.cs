using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using FlurlExample.API.Models;

namespace FlurlExample
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult>Get(int limit)
        {
            var url = "https://pokeapi.co/api/v2/pokemon";
            var result = await url.SetQueryParams(new { limit })
            .GetJsonAsync<NamedAPIResourceList>();
            return Ok(result);
        }
    }
}
