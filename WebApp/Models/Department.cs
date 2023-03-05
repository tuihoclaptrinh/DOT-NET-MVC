using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models;

public class Department
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int DepartmentId { get; set; }
    public string Name { get; set; }
    
    [InverseProperty("Department")]
    public virtual ICollection<Employee> Employees { get; set; }
}