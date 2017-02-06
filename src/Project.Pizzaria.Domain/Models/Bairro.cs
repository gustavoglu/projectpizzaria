using System;
using System.Collections.Generic;

namespace Project.Pizzaria.Domain.Models
{
    public class Bairro : EntityBase

    {

        public string Descricao { get; set; }

        public double Taxa { get; set; }

        public virtual ICollection<Endereco> Enderecos { get; set; }

    }
}
