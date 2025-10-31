using LinkupApp.APIs.Entities;
using Microsoft.EntityFrameworkCore;

namespace LinkupApp.APIs.Data
{
    public class AppDbContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<AppUser> Users { get; set; }
    }
}
