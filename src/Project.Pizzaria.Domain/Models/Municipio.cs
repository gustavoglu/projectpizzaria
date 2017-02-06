
using System;
using System.Collections.Generic;


namespace Project.Pizzaria.Domain.Models
{
   
    public class Municipio : EntityBase
    {

        public string Descricao { get; set; }

        public virtual ICollection<Endereco> Enderecos { get; set; }

    }
}
