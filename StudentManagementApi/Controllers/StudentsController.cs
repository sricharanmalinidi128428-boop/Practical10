using Microsoft.AspNetCore.Mvc;
using StudentManagementApi.Models;

namespace StudentManagementApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentsController : ControllerBase
{
    private static readonly List<Student> Students = new()
    {
        new Student { Id = 1, Name = "Asha Kumar", Email = "asha@example.com", Course = "CSE", Year = 3 },
        new Student { Id = 2, Name = "Rahul Das", Email = "rahul@example.com", Course = "IT", Year = 3 }
    };

    [HttpGet]
    public ActionResult<List<Student>> GetAll() => Ok(Students);

    [HttpGet("{id:int}")]
    public ActionResult<Student> GetById(int id)
    {
        var student = Students.FirstOrDefault(s => s.Id == id);
        return student is null ? NotFound() : Ok(student);
    }

    [HttpPost]
    public ActionResult<Student> Create(Student student)
    {
        student.Id = Students.Count == 0 ? 1 : Students.Max(s => s.Id) + 1;
        Students.Add(student);
        return CreatedAtAction(nameof(GetById), new { id = student.Id }, student);
    }

    [HttpPut("{id:int}")]
    public IActionResult Update(int id, Student updatedStudent)
    {
        var student = Students.FirstOrDefault(s => s.Id == id);
        if (student is null) return NotFound();

        student.Name = updatedStudent.Name;
        student.Email = updatedStudent.Email;
        student.Course = updatedStudent.Course;
        student.Year = updatedStudent.Year;
        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public IActionResult Delete(int id)
    {
        var student = Students.FirstOrDefault(s => s.Id == id);
        if (student is null) return NotFound();

        Students.Remove(student);
        return NoContent();
    }
}
