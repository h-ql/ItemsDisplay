using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ItemsDisplay.Models;
using System.Text.Json;
using ItemsDisplay.Data;
using ItemsDisplay.Services;

namespace ItemsDisplay.Controllers;

public class HomeController : Controller
{
    private readonly ICharacterService _service;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, ICharacterService service)
    {
        _service = service;
        _logger = logger;
    }

    public ActionResult<IEnumerable<Character>> Index()
    {
        return View(_service.GetAll());
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
