using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission08_Team0209.Models;

namespace Mission08_Team0209.Controllers;

public class HomeController : Controller
{

    private ITaskRepository _repo;

    public HomeController(ITaskRepository temp) //constructor
    {
        _repo = temp;
    }

    //karen look at the repostiory pattern video #4 &#5 to fix the homecontroller stuff
    public IActionResult Quadrants()
    {
        return View();
    }
    
}
