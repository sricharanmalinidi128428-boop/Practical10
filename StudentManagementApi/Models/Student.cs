using System.ComponentModel.DataAnnotations;

namespace StudentManagementApi.Models;

public class Student
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = "";

    [Required, EmailAddress]
    public string Email { get; set; } = "";

    [Required]
    public string Course { get; set; } = "";

    [Range(1, 4)]
    public int Year { get; set; }
}
