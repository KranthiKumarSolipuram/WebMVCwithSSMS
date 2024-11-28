using Microsoft.EntityFrameworkCore;
using WebMVCwithSSMS.MVC.Models;

namespace WebMVCwithSSMS.MVC.Models.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options) { }

        public DbSet<ToDo> ToDos { get; set; }
    }

    
}
