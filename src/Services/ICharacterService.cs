

using ItemsDisplay.Models;

namespace ItemsDisplay.Services;

public interface ICharacterService 
{
    CharacterAttributeViewModel GetByAttrAndSearchString(string CharacterAttribute, string searchString);
    
    // List<Character> GetNameByString(string searchString);
    IEnumerable<Character> GetAll();
    Character GetByID(int id);
}