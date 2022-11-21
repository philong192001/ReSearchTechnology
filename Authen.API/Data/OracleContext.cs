using Authen.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authen.API.Data
{
    public class OracleContext : DbContext
    {

        public OracleContext(DbContextOptions<OracleContext> options) : base(options)
        {

        }
        public DbSet<CheckLogin> ResponseLogin { get; set; }
        public DbSet<UserTest> UserLogin { get; set; }
        public DbSet<Permit> Permits { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

    
}
