using System;
using System.Collections.Generic;

namespace Project.Pizzaria.Domain.Models
{
    public class Produto_Tipo : EntityBase
    {

        public string Descricao { get; set; }

        public ICollection<Produto> Produtos { get; set; }

    }
}
