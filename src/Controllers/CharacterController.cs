using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ItemsDisplay.Models;
using System.Text.Json;
using ItemsDisplay.Data;
using ItemsDisplay.Services;
using System;
using Microsoft.EntityFrameworkCore;

namespace ItemsDisplay.Controllers;


public class CharacterController : Controller
{
    private readonly ICharacterService _service;
    private readonly ILogger<CharacterController> _logger;
    private readonly IWebHostEnvironment Environment;

    public CharacterController(ILogger<CharacterController> logger, ICharacterService service, IWebHostEnvironment environment)
    {
        _service = service;
        _logger = logger;
        this.Environment = environment;
    }
    

    // GET: CharacterAttributeViewModel
    public async Task<ActionResult<CharacterAttributeViewModel>> Index(string characterAttribute, string searchString)
    {
        return View(await _service.GetByAttrAndSearchString(characterAttribute, searchString));
    }
    
    // GET: CharacterAttributeViewModel/Details/{id}
    public async Task<ActionResult<Character>> Details(int id)
    {
        try {
            _logger.LogInformation("Item with ID : {id} was successful fetch");
            return View(await _service.GetByID(id));
        } 
        catch (NullReferenceException) {
            return NotFound();
        }
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Name,Attribute,AttackType,Description")]
                        Character character, List<IFormFile> files)
    {
        if (ModelState.IsValid)
        {
            if ((files.FirstOrDefault()?.Length ?? 0) > 0)
				{
					var filePath = Path.Combine(this.Environment.WebRootPath, 
						"collectionImages", 
						character.Name + ".jpg");

					using (var stream = System.IO.File.Create(filePath))
					{
						await files.First().CopyToAsync(stream);
					}

					character.ImgURL = $"/collectionImages/{character.Name}.jpg";
                }

                await _service.AddAndSave(character);
                return RedirectToAction(nameof(Index));
        }
        return View(character);
    }

    public async Task<IActionResult> Edit(int id)
    {
         try {
            _logger.LogInformation("Item with ID : {id} was found");
            return View(await _service.FindByID(id));
        } 
        catch (NullReferenceException) {
            return NotFound();
        }
    }
    [HttpPost]

    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, 
                [Bind("Id,Name,Attribute,AttackType,Description,ImgURL")] Character character)
    {
        if(id!= character.Id)
        {
            return NotFound();
        }
        if (ModelState.IsValid)
        {
            await _service.UpdateAndSave(id, character);
            return RedirectToAction(nameof(Details));
        }
        return View(character);
    }
    

    #region /swagger

    [HttpGet("/api/Items")]
    public async Task<ActionResult<IEnumerable<Character>>> GetAllItems() => Ok(await _service.GetAll());
    
    
    [HttpGet("/api/Items/{id:int}")]
    public async Task<ActionResult<Character>> GetItemByID(int id)
    {
        try {
            _logger.LogInformation("Item with ID : {id} was successful fetch");
            return Ok(await _service.GetByID(id));
        } 
        catch (NullReferenceException) {
            return NotFound();
        }
    }
    #endregion

    #region // Privacy & Error default
    public IActionResult Privacy() => View();    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });  
    #endregion

}