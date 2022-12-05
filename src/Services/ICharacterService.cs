

using ItemsDisplay.Models;

namespace ItemsDisplay.Services;

public interface ICharacterService 
{
    Task<CharacterAttributeViewModel> GetAllAsync(string CharacterAttribute, string searchString);
  
    Task<Character> GetByIdAsync(int id);
    Task<Character> FindByIdAsync(int? id);

    
   

    Task<List<Character>> AddCharacterAsync(Character character);
    Task<List<Character>> UpdateCharacterAsync(Character character);
    Task<List<Character>> DeleteCharacterAsync(int id);

}