using Project.Pizzaria.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Pizzaria.Infra.Data.EntityConfig
{
    public class MunicipioConfig : EntityTypeConfiguration<Municipio>
    {
        public MunicipioConfig()
        {
            ToTable("municipio");

            Property(m => m.Descricao).IsRequired().HasMaxLength(50);

        }
    }
}
