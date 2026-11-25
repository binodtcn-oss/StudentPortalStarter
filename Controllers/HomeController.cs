using Microsoft.AspNetCore.Mvc;

namespace StudentPortal.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewData["Title"] = "Home";
        ViewBag.Message = "Welcome to the ASP.NET MVC training demo!";
        return View();
    }
}
