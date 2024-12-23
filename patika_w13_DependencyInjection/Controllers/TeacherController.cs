using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using patika_w13_DependencyInjection.Interfaces;

namespace patika_w13_DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacher _teacher;

        public TeacherController(ITeacher teacher)
        {
            _teacher = teacher;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var info = _teacher.GetInfo();
            return Ok(info);
        }
    }
}
