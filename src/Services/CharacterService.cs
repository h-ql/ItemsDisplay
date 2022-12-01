using ItemsDisplay.Data;
using ItemsDisplay.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ItemsDisplay.Services;

public class CharacterService : ICharacterService
{
    private readonly CharacterContext _ctx;

    public CharacterService(CharacterContext ctx)
    {
        _ctx = ctx;
    }

    public CharacterAttributeViewModel GetByAttrAndSearchString(string characterAttribute, string searchString)
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
            heros = heros.Where(s => s.Name!.Contains(searchString));
        }

        if (!String.IsNullOrEmpty(characterAttribute))
        {
            heros = heros.Where(x => x.Attribute == characterAttribute);
        }
        
        var charAttributeVM = new CharacterAttributeViewModel
        {
            Attributes = new SelectList(attrQuerry.Distinct().ToList()),
            Characters = heros.ToList()
        };
        return charAttributeVM; 
        // throw new NotImplementedException();
    }

    // public List<Character> GetNameByString(string searchString)
    // {
    //     if(_ctx.Characters == null)
    //     {
    //         throw new NullReferenceException("Item not found");
    //     }
    //     var heros = from h in _ctx.Characters select h;

    //     if(!String.IsNullOrEmpty(searchString))
    //     {
    //         heros = heros.Where(s => s.Name!.Contains(searchString));
    //     }
    //     return heros.ToList();
    // }

    public IEnumerable<Character> GetAll()
    {
        return _ctx.Characters.ToArray();
    }
    
    public Character GetByID(int id)
    {
        var output = _ctx.Characters.FirstOrDefault(i => id == i.Id);
        if (output == null)
        { 
            throw new NullReferenceException("Item not found");
        }
        return output;
    }
    
}
