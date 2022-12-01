using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ItemsDisplay.Models;
using System.Text.Json;
using ItemsDisplay.Data;
using ItemsDisplay.Services;

namespace ItemsDisplay.Controllers;


public class CharacterController : Controller
{
    private readonly ICharacterService _service;
    private readonly ILogger<CharacterController> _logger;

    public CharacterController(ILogger<CharacterController> logger, ICharacterService service)
    {
        _service = service;
        _logger = logger;
    }

    // public ActionResult<IEnumerable<Character>> Index()
    // {
    //     _logger.LogCritical("Something request this !!!");
    //     return View(_service.GetAll());
    // }

    public ActionResult<CharacterAttributeViewModel> Index(string characterAttribute, string searchString)
    {
        return View(_service.GetByAttrAndSearchString(characterAttribute, searchString));
    }

    // public ActionResult Index(string searchString)
    // {
    //     return View(_service.GetNameByString(searchString));
    // }




    [HttpGet("/api/Items/{whereNameStartsWith?}/{orderBy?}")]
    public ActionResult<IEnumerable<Character>> GetApi(
        string? whereNameStartsWith,
        string? orderBy)
    {

        Func<Character,string> orderByFunc = orderBy switch
        {
            "name" => item => item.Name,
            "description" => item => item.Description,
            _ => item => item.Name
        };

        // TODO: Inspect why this isn't returning
        if (string.IsNullOrEmpty(whereNameStartsWith)) {
            return Ok(
                _service.GetAll().ToArray()
                .OrderBy(orderByFunc)
            );
        }

        return Ok(
            _service.GetAll()
                .Where(i => i.Name.StartsWith(whereNameStartsWith, true, null))
                .OrderBy(orderByFunc)
            );
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
