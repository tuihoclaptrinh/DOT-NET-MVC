using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models;

public class Author
{
    [Key]
    public int AuthorId { get; set; }
    
    [Required]
    [StringLength(50)]
    public string? Name { get; set; }

    [Column(TypeName = "Money")]
    public decimal Salary { get; set; }
    
    [InverseProperty("Author")]
    public virtual Book? Book { get; set; }
    
}