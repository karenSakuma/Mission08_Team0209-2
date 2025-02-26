using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission08_Team0209.Models;

namespace Mission08_Team0209.Controllers;

public class HomeController : Controller
{

    private TaskCollectionContext _context;

    public HomeController(TaskCollectionContext temp) //constructor
    {
        _context = temp;
    }

    public IActionResult Index()
    {
        return View();
    }
    
}
