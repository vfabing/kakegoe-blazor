using System.Threading.Tasks;
using KakegoeBlazor.Server.Application.Songs.Queries.GetSongs;
using Microsoft.AspNetCore.Mvc;

namespace KakegoeBlazor.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SongsController : ControllerBase
    {
        private readonly GetSongsQueryHandler _handler;

        public SongsController(GetSongsQueryHandler handler)
        {
            _handler = handler;
        }

        [HttpGet]
        public async Task<ActionResult> GetSongs()
        {
            return Ok(await _handler.HandleAsync(new GetSongsQuery { }));
        }
    }
}
