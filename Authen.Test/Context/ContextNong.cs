using Authen.Test.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authen.Test.Context
{
    public class ContextNong : DbContext
    {
        public ContextNong(DbContextOptions<ContextNong> options) : base(options)
        {
           
        }

        public DbSet<TauthUserlogin> TAUTH_USERLOGIN { get; set; }
        public DbSet<TauthClientsession> TAUTH_CLIENTSESSION { get; set; }
        public DbSet<TauthClientsessionlog> TAUTH_CLIENTSESSIONLOG { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
