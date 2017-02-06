using Project.Pizzaria.Domain.Models;
using Project.Pizzaria.Infra.Data.EntityConfig;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Project.Pizzaria.Infra.Data.Context
{
    public class ContextSQLServer : DbContext
    {
        public ContextSQLServer() : base("project")
        {

        }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Produto_Tipo> Produto_Tipos { get; set; }

        public DbSet<Conta> Contas { get; set; }

        public DbSet<Conta_Tipo> Conta_Tipos { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }

        public DbSet<Bairro> Bairros { get; set; }

        public DbSet<Uf> Ufs { get; set; }

        public DbSet<Municipio> Municipios { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

           modelBuilder.Properties().Where(p => p.Name == "Id").Configure(p => p.IsKey());

            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new ProdutoConfig());
            modelBuilder.Configurations.Add(new Produto_TipoConfig());
            modelBuilder.Configurations.Add(new EnderecoConfig());
            modelBuilder.Configurations.Add(new ContaConfig());
            modelBuilder.Configurations.Add(new Conta_TipoConfig());
            modelBuilder.Configurations.Add(new BairroConfig());
            modelBuilder.Configurations.Add(new UfConfig());
            modelBuilder.Configurations.Add(new MunicipioConfig());

        
        }
    }
}
