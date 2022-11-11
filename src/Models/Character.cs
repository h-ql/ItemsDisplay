using System.ComponentModel.DataAnnotations;

namespace ItemsDisplay.Models;

public class Character 
{
    [Key]
	public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    public string Attribute { get; set; }
    public string AttackType { get; set; }
    public string? Description { get; set; }
    public string? ImgURL { get; set; }
}