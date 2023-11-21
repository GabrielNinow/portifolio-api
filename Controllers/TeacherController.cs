using Microsoft.AspNetCore.Mvc;

namespace PortifolioAPI.Controllers;

[ApiController]
[Route("api/[Controller]")]
public class TeacherController : ControllerBase
{
    [HttpGet]
    public IActionResult Index()
    {
        return Ok("Teachers: gabriel, braian");
    }
}