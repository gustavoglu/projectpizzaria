using System;
using System.Collections.Generic;

namespace Project.Pizzaria.Domain.Models
{
    public class Uf : EntityBase
    {

        public string Descricao { get; set; }

        public ICollection<Endereco> Enderecos{ get; set; }
    }
}
