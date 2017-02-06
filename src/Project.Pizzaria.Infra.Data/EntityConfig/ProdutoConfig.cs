using Project.Pizzaria.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Pizzaria.Infra.Data.EntityConfig
{
    public class ProdutoConfig : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfig()
        {
            ToTable("produto");

            HasRequired(p => p.Produto_tipo)
                .WithMany(pt => pt.Produtos)
                .HasForeignKey(p => p.Id_produto_tipo);

            Property(p => p.Descricao).IsRequired().HasMaxLength(100);

            Property(p => p.Observacoes).IsOptional().HasMaxLength(300);

            Property(p => p.ImagemUri).IsOptional().HasMaxLength(1000);

  

        }
    }
}
