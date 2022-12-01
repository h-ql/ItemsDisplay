using System.ComponentModel.DataAnnotations;

namespace ItemsDisplay.Models;

public class Character 
{
    [Key]
	public int Id { get; set; }

    [StringLength(60, MinimumLength = 3), Required]
    public string Name { get; set; } = null!;

    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(15)]
    public string Attribute { get; set; } = null!;

    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(15)]
    public string AttackType { get; set; } = null!;
    
    public string? Description { get; set; }
    public string? ImgURL { get; set; }
}