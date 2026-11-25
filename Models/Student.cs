using System.ComponentModel.DataAnnotations;

namespace StudentPortal.Models;

public class Student
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Name is required")]
    [StringLength(60)]
    public string Name { get; set; } = string.Empty;

    [Required, EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Range(1, 8, ErrorMessage = "Semester must be between 1 and 8")]
    public int Semester { get; set; } = 1;
}
