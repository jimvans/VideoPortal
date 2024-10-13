using Microsoft.AspNetCore.Mvc;
using video_app_api.Data;

namespace video_app_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VideosController : ControllerBase
    {
        private readonly ApplicationContext _context;

    }
}
