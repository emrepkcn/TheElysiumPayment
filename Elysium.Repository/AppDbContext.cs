using Elysium.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Elysium.Repository
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<AdminUser> AdminUsers { get; set; }
        public DbSet<CookiePolicies> CookiePolicies { get; set; }
        public DbSet<Hotels> Hotels { get; set; }
        public DbSet<Lang> Langs { get; set; }
        public DbSet<Logger> Loggers { get; set; }
        public DbSet<ProductLabel> ProductLabels { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<WebLang> WebLangs { get; set; }
        public DbSet<WebUser> WebUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }

    }
}
