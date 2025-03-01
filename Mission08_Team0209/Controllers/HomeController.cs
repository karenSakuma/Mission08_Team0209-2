using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission08_Team0209.Models;
using Task = Mission08_Team0209.Models.Task;

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
    
    //[HttpGet]
    public IActionResult AddEdit(int? id)
    {
        if (id == null)
        {
            // Add mode: Return an empty model
            var model = new Task(); // New empty task model
            ViewBag.Categories = _repo.GetCategories(); // Populate dropdown data using the repository
            return View(model);
        }
        else
        {
            // Edit mode: Fetch the existing model
            var model = _repo.GetTaskById(id.Value); // Use the repository to fetch the task by id
            if (model == null)
            {
                return NotFound(); // Return a 404 if no task is found
            }
            ViewBag.Categories = _repo.GetCategories(); // Fetch categories again using the repository
            return View(model);
        }
    }
    
    [HttpPost]
    public IActionResult AddEdit(Task task)
    {
        if (ModelState.IsValid)
        {
            if (task.TaskId == 0)
            {
                // Add new task
                _repo.AddTask(task);
            }
            else
            {
                // Update existing task
                _repo.UpdateTask(task);
            }

            return RedirectToAction("Quadrants"); // Redirect to a list or details page after saving
        }
        
        ViewBag.Categories = _repo.GetCategories();
        return View(task);
    }

    
/*    public IActionResult AddEdit(int? id)
    {
        if (id == null)
        {
            // Add mode: Return an empty model
            var model = new Task();
            ViewBag.Categories = _repo.GetCategories(); // Populate dropdown data
            return View(model);
        }
        else
        {
            // Edit mode: Fetch the existing model
            var model = _repo.GetTaskById(id.Value);
            if (model == null)
            {
                return NotFound();
            }
            ViewBag.Categories = _repo.GetCategories();
            return View(model);
        }
    }
    */
}
