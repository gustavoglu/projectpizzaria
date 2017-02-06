using System;
using System.Data.Entity;
using EP.IdentityIsolation.Infra.CrossCutting.Identity.Model;
using Microsoft.AspNet.Identity.EntityFramework;

namespace EP.IdentityIsolation.Infra.CrossCutting.Identity.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IDisposable
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityUser>()
            .ToTable("usuarios")
            .Property(p => p.Id)
            .HasColumnName("id");

            modelBuilder.Entity<ApplicationUser>()
            .ToTable("usuarios")
            .Property(p => p.Id)
            .HasColumnName("id");

            modelBuilder.Entity<IdentityUserRole>()
            .ToTable("usuarios_regras");

            modelBuilder.Entity<IdentityUserLogin>().ToTable("logins");

            modelBuilder.Entity<IdentityUserClaim>()
            .ToTable("claims");

            modelBuilder.Entity<IdentityRole>()
            .ToTable("regras");

         
        }
    }
}