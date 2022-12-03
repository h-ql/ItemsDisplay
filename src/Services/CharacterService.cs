using ItemsDisplay.Data;
using ItemsDisplay.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ItemsDisplay.Services;

public class CharacterService : ICharacterService
{
    private readonly CharacterContext _ctx;
    private readonly ILogger<CharacterService> _logger;

    public CharacterService(CharacterContext ctx, ILogger<CharacterService> logger)
    {
        _ctx = ctx;
        _logger = logger;
    }

    public async Task<CharacterAttributeViewModel> GetByAttrAndSearchString(string characterAttribute, string searchString)
    {
        if (_ctx.Characters == null)
        {
            throw new NullReferenceException("No database context was set");
        }
        IQueryable<string> attrQuerry = from c in _ctx.Characters
                                        orderby c.Attribute
                                        select c.Attribute;

                            var heros = from h in _ctx.Characters
                                        select h;

        if(!String.IsNullOrEmpty(searchString))
        {
            heros = heros.Where(s => s.Name!.ToLower().Contains(searchString.Trim().ToLower()));                                                 
        }       
        if (!String.IsNullOrEmpty(characterAttribute))
        {
            heros = heros.Where(x => x.Attribute == characterAttribute);
        }        
        var charAttributeVM = new CharacterAttributeViewModel
        {
            Attributes = new SelectList(await attrQuerry.Distinct().ToListAsync()),
            Characters = await heros.ToListAsync()
        };
        return charAttributeVM;       
    }

    public async Task<IEnumerable<Character>> GetAll() =>  await _ctx.Characters.ToArrayAsync();
   
    public async Task<Character> GetByID(int id)
    {
        var output = await _ctx.Characters.FirstOrDefaultAsync(i => id == i.Id);
        if (output == null)
        { 
            throw new NullReferenceException("Item not found");
        }
        return output;
    }
    public async Task<Character> FindByID(int id)
    {
        var output = await _ctx.Characters.FindAsync(id);
        if (output == null)
        { 
            throw new NullReferenceException("Item not found");
        }
        return output;
    }    

    public async Task AddAndSave(Character character)
    {      
        _ctx.Add(character);
        await _ctx.SaveChangesAsync();           
    }
    public async Task UpdateAndSave(int id,Character character)
    {
        if (id != character.Id) 
        try
        {
            _ctx.Update(character);
            await _ctx.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException ex)
        {
            _logger.LogError("Something occur in CharacterService err msg: {ex.Message}", ex);
        }
    }
}
