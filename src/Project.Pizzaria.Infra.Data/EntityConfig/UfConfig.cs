using Project.Pizzaria.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Pizzaria.Infra.Data.EntityConfig
{
    public class UfConfig : EntityTypeConfiguration<Uf>
    {
        public UfConfig()
        {
            ToTable("uf");

            Property(u => u.Descricao).IsRequired().HasMaxLength(2).IsFixedLength();

        }
    }
}
