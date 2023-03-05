using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models;

public class Employee
{
    public int EmployeeId { get; set; }
    public string Name { get; set; }
    
    public int DepartmentId { get; set; }
    [ForeignKey("DepartmentId")]
    [InverseProperty("Employees")]
    public virtual Department Department { get; set; }
}