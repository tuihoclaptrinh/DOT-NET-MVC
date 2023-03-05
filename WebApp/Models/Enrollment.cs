using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models;

public class Enrollment
{
    [Key]
    [Column(Order = 0)]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int EnrollmentId { get; set; }

    public DateTime EnrollmentDate { get; set; }

    public decimal Grade { get; set; }
    
    [Key]
    [Column(Order = 1)]
    public int StudentId { get; set; }
    [ForeignKey("StudentId")]
    public Student Student { get; set; }

    [Key]
    [Column(Order = 2)]
    public int CourseId { get; set; }
    [ForeignKey("CourseId")]
    public Course Course { get; set; }
}