using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OceanLeader.Models;

namespace OceanLeader.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Warehouses()
    {
        return View();
    }

    public IActionResult Menu()
    {
        return View();
    }

    public IActionResult Labels()
    {
        return View();
    }

    public IActionResult Entries()
    {
        return View();
    }

    public IActionResult Orders()
    {
        return View();
    }

    public IActionResult Deliveries()
    {
        return View();
    }

    public IActionResult Queries()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
