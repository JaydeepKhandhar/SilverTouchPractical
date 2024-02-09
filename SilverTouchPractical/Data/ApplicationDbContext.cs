using Microsoft.EntityFrameworkCore;
using SilverTouchPractical.Models;

namespace SilverTouchPractical.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Registration> Registrations { get; set; }
    }
}
