using Formacao_.net.API.Models;
using Formacao_.net.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Formacao_.net.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly FreelancerTotalConstConfig _config;
        private readonly IConfigService _configService;
        public ProjectsController(IOptions<FreelancerTotalConstConfig> options,
            IConfigService configService) 
        {
            _config = options.Value;
            _configService = configService;
        }

        [HttpGet]
        public IActionResult Get(string search = "")
        {
            return Ok(_configService.GetValue());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id) 
        {
            throw new Exception();
            return Ok();
        }

        [HttpPost]
        public IActionResult Post(CreateProjectsInputModel model)
        {
            if(model.TotalCost < _config.Minimum || model.TotalCost < _config.Maximum)
            {
                return BadRequest("Numero fora do limite");
            }
            return CreatedAtAction(nameof(GetById), new { id = 1 }, model);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, UpdateProjectsInputModel updateProjectsInputModel)
        {
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) 
        {
            return NoContent();
        }

        [HttpPut("{id}/start")]
        public IActionResult Start(int id)
        {
            return NoContent();
        }

        [HttpPut("{id}/complete")]
        public IActionResult Complete(int id)
        {
            return NoContent();
        }

        [HttpPost("{id}/comments")]
        public IActionResult PostComments(int id, CreateProjectCommentInputModel createProjectCommentInputModel)
        {
            return NoContent();
        }
    }
}
