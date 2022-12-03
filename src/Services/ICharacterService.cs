

using ItemsDisplay.Models;

namespace ItemsDisplay.Services;

public interface ICharacterService 
{
    Task<CharacterAttributeViewModel> GetByAttrAndSearchString(string CharacterAttribute, string searchString);
    
    // List<Character> GetNameByString(string searchString);
    Task<IEnumerable<Character>> GetAll();
    Task<Character> GetByID(int id);
    Task AddAndSave(Character character);

    Task UpdateAndSave(int id,Character character);
    Task<Character> FindByID(int id);
}