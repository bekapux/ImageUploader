using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ImageUploader.API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ImagesController : ControllerBase
  {
    [HttpPost]
    public async Task<IActionResult> Upload(IFormFile file)
    {
      if (file == null || file.Length == 0) return BadRequest();
      return Ok();
    }
  }
}
