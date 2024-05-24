using Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UserDemoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkExperienceController : ControllerBase
    {
        private readonly WorkExperienceService _service;

        public WorkExperienceController(WorkExperienceService service) 
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.Get());
        }

        [HttpGet("{title}")]
        public IActionResult GetByTitle(string title)
        {
            return Ok(_service.Get(title));
        }

    }
}
