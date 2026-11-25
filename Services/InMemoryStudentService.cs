using StudentPortal.Models;

namespace StudentPortal.Services;

// Simple in-memory store. Replace with Entity Framework Core for a real database.
public class InMemoryStudentService : IStudentService
{
    private readonly List<Student> _students = new()
    {
        new Student { Id = 1, Name = "Anita Gurung", Email = "anita@example.com", Semester = 1 },
        new Student { Id = 2, Name = "Bikash Thapa", Email = "bikash@example.com", Semester = 2 },
        new Student { Id = 3, Name = "Sita Sharma",  Email = "sita@example.com",  Semester = 3 }
    };
    private int _nextId = 4;

    public List<Student> GetAll() => _students.OrderBy(s => s.Id).ToList();

    public Student? GetById(int id) => _students.FirstOrDefault(s => s.Id == id);

    public void Add(Student student)
    {
        student.Id = _nextId++;
        _students.Add(student);
    }

    public void Update(Student student)
    {
        var existing = GetById(student.Id);
        if (existing == null) return;
        existing.Name = student.Name;
        existing.Email = student.Email;
        existing.Semester = student.Semester;
    }

    public void Delete(int id) => _students.RemoveAll(s => s.Id == id);
}
