using Microsoft.AspNetCore.Mvc;
using StudentManagementApi.Models;
using StudentManagementApi.Services;

namespace StudentManagementApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentsController : ControllerBase
{
    private readonly StudentService _students;

    public StudentsController(StudentService students)
    {
        _students = students;
    }

    [HttpGet]
    public ActionResult<List<Student>> GetAll() => Ok(_students.GetAll());

    [HttpGet("{id:int}")]
    public ActionResult<Student> GetById(int id)
    {
        var student = _students.GetById(id);
        return student is null ? NotFound() : Ok(student);
    }

    [HttpPost]
    public ActionResult<Student> Create(Student student)
    {
        _students.Add(student);
        return CreatedAtAction(nameof(GetById), new { id = student.Id }, student);
    }

    [HttpPut("{id:int}")]
    public IActionResult Update(int id, Student updatedStudent)
    {
        return _students.Update(id, updatedStudent) ? NoContent() : NotFound();
    }

    [HttpDelete("{id:int}")]
    public IActionResult Delete(int id)
    {
        return _students.Delete(id) ? NoContent() : NotFound();
    }
}
