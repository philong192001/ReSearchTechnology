using IDServer4.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IDServer4.Data
{
    public class DataContext : IdentityDbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }
        
        //DbSet<Login> Logins { get; set; }
        //DbSet<Register> Registers { get; set; }

        //DbSet<ExternalRegister> ExternalRegisters { get; set; }
    }
}
