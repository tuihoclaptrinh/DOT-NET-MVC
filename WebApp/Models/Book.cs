using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models;

public class Book
{
    [Key]
    public int BookId { get; set; }

    [Required]
    [StringLength(50)]
    public string? Title { get; set; }
    
    [Column("ISBN")]
    public string? Isbn { get; set; }

    [Column(TypeName = "Money")]
    public decimal Price { get; set; }
    
    public int AuthorId { get; set; }
    
    [ForeignKey("AuthorId")]
    [InverseProperty("Book")]
    public virtual Author? Author { get; set; }
    
}