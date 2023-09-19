using ChnageTrackerLearn.Models;
using Microsoft.EntityFrameworkCore;

namespace ChnageTrackerLearn.Data;

public class StudentDbContext : DbContext
{
    public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
    {
        
    }
    
    public virtual DbSet<Student> Students { get; set; }
}