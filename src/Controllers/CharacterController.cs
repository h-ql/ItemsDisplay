
using ItemsDisplay.Services;
using Microsoft.AspNetCore.Mvc;

public class CharacterController : Controller
{
    private readonly ILogger<CharacterController> _logger;
    private readonly ICharacterService _service;

    public CharacterController(ILogger<CharacterController> logger, ICharacterService service)
    {
        _logger = logger;
        _service = service;
    }
    // public IActionResult Index(string CharacterAttribute, string searchString)
    // {
    //     return View( _service.GetByAttrAndSearchString(CharacterAttribute, searchString));
    // }
}