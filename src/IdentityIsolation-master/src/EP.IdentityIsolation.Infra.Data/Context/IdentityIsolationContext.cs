using System.Data.Entity;
using EP.IdentityIsolation.Domain.Portable.Entities;
using EP.IdentityIsolation.Infra.Data.EntityConfig;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EP.IdentityIsolation.Infra.Data.Context
{
    public class IdentityIsolationContext : DbContext
    {
        public IdentityIsolationContext()
            : base("pizzaria")
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new UsuarioConfig());

            base.OnModelCreating(modelBuilder);


        }
    }
}