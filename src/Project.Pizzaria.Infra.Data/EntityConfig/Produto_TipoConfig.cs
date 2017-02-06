using Project.Pizzaria.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Pizzaria.Infra.Data.EntityConfig
{
   public class Produto_TipoConfig : EntityTypeConfiguration<Produto_Tipo>
    {
        public Produto_TipoConfig()
        {
            ToTable("produto_tipo");

            Property(pt => pt.Descricao).IsRequired().HasMaxLength(100);
        }
    }
}
