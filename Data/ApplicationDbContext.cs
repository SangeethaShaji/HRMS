using HRMS.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace HRMS.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }
        public DbSet<Employess>Employess { get; set; }
    }
}
