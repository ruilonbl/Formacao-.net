using Microsoft.AspNetCore.Mvc;

namespace Formacao_.net.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post()
        {
            return Ok();
        }

        [HttpPost("{id}/profile-picture")]
        public IActionResult PostProfilePicture(IFormFile file)
        {
            var description = $"FILE: {file.Name}, size: {file.Length}";
            return Ok(description);
        }
    }
}
