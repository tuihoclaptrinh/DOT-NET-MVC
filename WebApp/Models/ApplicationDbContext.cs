using Microsoft.EntityFrameworkCore;

namespace WebApp.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    public DbSet<Author>? Authors { get; set; }
    public DbSet<Book>? Books { get; set; }
    public DbSet<Department>? Departments { get; set; }
    public DbSet<Employee>? Employees { get; set; }
    public DbSet<Student>? Students { get; set; }
    public DbSet<Course>? Courses { get; set; }
    public DbSet<Enrollment>? Enrollments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Enrollment>()
            .HasKey(e => new { e.EnrollmentId, e.StudentId, e.CourseId });
    }
    
}