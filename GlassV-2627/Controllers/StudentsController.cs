using GlassV_2627.Data;
using Microsoft.AspNetCore.Mvc;

namespace GlassV_2627.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class StudentsController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    
    public StudentsController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetAllStudents()
    {
        var students = _context.Students.ToList();
        return Ok(students);
    }

    [HttpGet]
    public IActionResult GetOneStudent([FromQuery] int id)
    {
        var student = _context.Students.Where(x => x.Id == id).First();
        return Ok(student);
    }
}