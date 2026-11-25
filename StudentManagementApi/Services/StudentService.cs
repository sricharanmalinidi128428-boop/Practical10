using StudentManagementApi.Models;

namespace StudentManagementApi.Services;

public class StudentService
{
    private readonly List<Student> _students = new()
    {
        new Student { Id = 1, Name = "Asha Kumar", Email = "asha@example.com", Course = "CSE", Year = 3 },
        new Student { Id = 2, Name = "Rahul Das", Email = "rahul@example.com", Course = "IT", Year = 3 }
    };

    public List<Student> GetAll() => _students;

    public Student? GetById(int id) => _students.FirstOrDefault(s => s.Id == id);

    public Student Add(Student student)
    {
        student.Id = _students.Count == 0 ? 1 : _students.Max(s => s.Id) + 1;
        _students.Add(student);
        return student;
    }

    public bool Update(int id, Student updated)
    {
        var student = GetById(id);
        if (student is null) return false;

        student.Name = updated.Name;
        student.Email = updated.Email;
        student.Course = updated.Course;
        student.Year = updated.Year;
        return true;
    }

    public bool Delete(int id)
    {
        var student = GetById(id);
        return student is not null && _students.Remove(student);
    }
}
