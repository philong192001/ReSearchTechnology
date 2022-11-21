using Microsoft.EntityFrameworkCore;
using NugetPrivateTest.Config;

namespace NugetPrivateTest.ContextTest
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ConfigAddress());
        }
        public DbSet<User> users { get; set; }
    }
}
