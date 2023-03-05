using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models;

public class Course
{
    public int CourseId { get; set; }
    public string Title { get; set; }

    [InverseProperty("Course")]
    public ICollection<Enrollment> Enrollments { get; set; }
}