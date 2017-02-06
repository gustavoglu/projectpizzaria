using Project.Pizzaria.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Pizzaria.Infra.Data.EntityConfig
{
   public class BairroConfig : EntityTypeConfiguration<Bairro>
    {
        public BairroConfig()
        {
            ToTable("bairro");

            Property(b => b.Descricao).IsRequired().HasMaxLength(100);
            Property(b => b.Taxa).IsOptional().HasColumnType("float");
        }
    }
}
