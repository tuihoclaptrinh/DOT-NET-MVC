using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models;

public class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }

    [InverseProperty("Student")]
    public ICollection<Enrollment> Enrollments { get; set; }
}