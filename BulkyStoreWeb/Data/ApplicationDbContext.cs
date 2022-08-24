using BulkyStoreWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyStoreWeb.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { set; get; }
    }
}
