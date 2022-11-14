using ItemsDisplay.Data;
using ItemsDisplay.Models;

namespace ItemsDisplay.Services;

public class CharacterService : ICharacterService
{
    private readonly CharacterContext _ctx;

    public CharacterService(CharacterContext ctx)
    {
        _ctx = ctx;
    }
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
