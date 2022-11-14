

using ItemsDisplay.Models;

namespace ItemsDisplay.Services;

public interface ICharacterService 
{
    IEnumerable<Character> GetAll();
    Character GetByID(int id);
}