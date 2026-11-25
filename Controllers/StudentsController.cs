using Microsoft.AspNetCore.Mvc;
using StudentPortal.Models;
using StudentPortal.Services;

namespace StudentPortal.Controllers;

public class StudentsController : Controller
{
    private readonly IStudentService _service;

    public StudentsController(IStudentService service) => _service = service;

    // GET: /Students
    public IActionResult Index() => View(_service.GetAll());

    // GET: /Students/Details/1
    public IActionResult Details(int id)
    {
        var student = _service.GetById(id);
        return student == null ? NotFound() : View(student);
    }

    // GET: /Students/Create
    public IActionResult Create() => View();

    // POST: /Students/Create
    [HttpPost, ValidateAntiForgeryToken]
    public IActionResult Create(Student student)
    {
        if (!ModelState.IsValid) return View(student);
        _service.Add(student);
        return RedirectToAction(nameof(Index));
    }

    // GET: /Students/Edit/1
    public IActionResult Edit(int id)
    {
        var student = _service.GetById(id);
        return student == null ? NotFound() : View(student);
    }

    // POST: /Students/Edit/1
    [HttpPost, ValidateAntiForgeryToken]
    public IActionResult Edit(Student student)
    {
        if (!ModelState.IsValid) return View(student);
        _service.Update(student);
        return RedirectToAction(nameof(Index));
    }

    // GET: /Students/Delete/1
    public IActionResult Delete(int id)
    {
        var student = _service.GetById(id);
        return student == null ? NotFound() : View(student);
    }

    // POST: /Students/Delete/1
    [HttpPost, ActionName("Delete"), ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int id)
    {
        _service.Delete(id);
        return RedirectToAction(nameof(Index));
    }
}
