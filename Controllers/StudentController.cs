using Microsoft.AspNetCore.Mvc;
using PortifolioAPI.Models;

namespace PortifolioAPI.Controllers;

[ApiController]
[Route("api/[Controller]")]
public class StudentController : ControllerBase
{
    public List<Student> Students = new List<Student>()
    {
        new Student()
        {
            Id = 1,
            Name = "Gabriel",
            LastName = "Ninow",
            Phone = "5193743264"
        },
        new Student()
        {
            Id = 2,
            Name = "Róger",
            LastName = "Ninow",
            Phone = "5193764364"
        },
        new Student()
        {
            Id = 3,
            Name = "Pedro",
            LastName = "Paulo",
            Phone = "5191267264"
        },
    };
    
    public StudentController() { }
    
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(Students);
    }
    
    [HttpGet("{id:int}")]
    public IActionResult GetById(int id)
    {
        var student = Students.FirstOrDefault(a => a.Id == id);
        if (student == null)
        {
            return BadRequest("Can't find student");
        }
        
        return Ok(student);
    }
    [HttpGet("{name}")]
    public IActionResult GetByName(string name)
    {
        var student = Students.FirstOrDefault(a => a.Name.Contains(name));
        if (student == null)
        {
            return BadRequest("Can't find student");
        }
        
        return Ok(student);
    }
    
}