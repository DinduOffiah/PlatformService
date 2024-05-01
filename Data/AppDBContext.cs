using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PlatformService.Models;

namespace PlatformService.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options)
          : base(options)
        {
        }

        public DbSet<Platform> Platforms { get; set; }
    }
}
