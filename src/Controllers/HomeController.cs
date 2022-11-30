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
        _logger.LogCritical("Something request this !!!");
        return View(_service.GetAll());
    }

    [HttpGet("/api/Items")]
    public ActionResult<IEnumerable<Character>> GetAllItems()
    {
        return Ok(_service.GetAll());
    }


    [HttpGet("/api/Items/{id:int}")]
    public ActionResult<Character> GetItemByID(int id)
    {
        try {
            return Ok( _service.GetByID(id));
        } 
        catch (NullReferenceException) {
            return NotFound();
        }
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
