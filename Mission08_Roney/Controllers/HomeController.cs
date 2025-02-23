using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission08_Roney.Models;
using SQLitePCL;

namespace Mission08_Roney.Controllers;

public class HomeController : Controller
{

    private IBaseballRepository _repo;
    public HomeController(IBaseballRepository temp)
    {
        _repo = temp;
    }
    
    [HttpGet]
    public IActionResult Index()
    {
        return View(new Manager());
    }

    [HttpPost]

    public IActionResult Index(Manager manager)
    {
        if (ModelState.IsValid)
        {
            _repo.AddManager(manager);
        }
        return View(new Manager());
    }
}