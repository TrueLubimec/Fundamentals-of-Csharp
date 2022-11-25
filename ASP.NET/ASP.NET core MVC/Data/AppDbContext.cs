using ASP.NET_core_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_core_MVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        
        public DbSet<Category> Categories { get; set; }
    }
}
