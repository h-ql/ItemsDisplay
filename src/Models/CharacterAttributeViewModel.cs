using Microsoft.AspNetCore.Mvc.Rendering;

namespace ItemsDisplay.Models;

public class CharacterAttributeViewModel 
{
    public List<Character>? Characters { get; set; }
    public SelectList? Attributes { get; set; }
    public string? CharacterAttribute { get; set; }
    public string? SearchString { get; set; }
}