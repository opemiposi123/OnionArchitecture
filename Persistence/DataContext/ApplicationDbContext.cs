using Domain.Entity;
using Microsoft.EntityFrameworkCore;



namespace Persistence.DataContext
{
    public class ApplicationDbContext : DbContext
    {   
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
            {

            }
            public DbSet<Student> Students { get; set; }
    }
}
