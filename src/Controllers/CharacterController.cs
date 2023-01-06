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
        return View(await _service.GetAllAsync(characterAttribute, searchString));
    }
    
    // GET: CharacterAttributeViewModel/Details/{id}
    public async Task<ActionResult<Character>> Details(int id)
    {
        try {
            _logger.LogInformation("Item with ID : {id} was successful fetch");
            return View(await _service.GetByIdAsync(id));
        } 
        catch (NullReferenceException) {
            return NotFound();
        }
    }

    // GET: Character/Create
    public IActionResult Create()
    {
        return View();
    }

    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(
        [Bind("Name,Attribute,AttackType,Description,ImgURL")]
                        Character character)
    {
        // ModelState.Remove("Id");
        if(ModelState.IsValid)
        {
            await _service.AddCharacterAsync(character);
            return RedirectToAction(nameof(Index));
        }
        _logger.LogWarning("Something happend");
        return View(character);
    }


    // GET: Character/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        try {
            _logger.LogInformation("Item with ID : {id} was found");
            return View(await _service.FindByIdAsync(id));
        } 
        catch (NullReferenceException) {
            return NotFound();
        }
    }

    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, 
                [Bind("Id,Name,Attribute,AttackType,Description,ImgURL")] Character character)
    {

        if(id != character.Id)
        {
            _logger.LogError($"Character with id: {id}, hasn't been found in db.");
            return NotFound();
        }  
        if(ModelState.IsValid)
        {
            try
            {
                await _service.UpdateCharacterAsync(character);
            }
            catch (System.Exception e)
            {
                _logger.LogError($"Something went wrong inside Edit action: {e.Message}");
                return StatusCode(500, "Internal server error");
            }
            return RedirectToAction(nameof(Index));
        }
        return View(character);
    }

    // GET: Character/Delete/5
    public async Task<IActionResult> Delete(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var hero = await _service.FindByIdAsync(id);
			if (hero == null)
			{
				return NotFound();
			}

			return View(hero);
		}
    
    // POST: Character/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        if(_service.FindByIdAsync(id) is null)
        {
           return BadRequest("'id' of object is null");
        }
        await _service.DeleteCharacterAsync(id);            
        return RedirectToAction(nameof(Index));
    }

    #region // Privacy & Error default
    public IActionResult Privacy() => View();    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });  
    #endregion

}