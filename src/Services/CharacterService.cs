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
}
