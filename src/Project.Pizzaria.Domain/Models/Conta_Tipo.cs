using System;
using System.Collections.Generic;

namespace Project.Pizzaria.Domain.Models
{
   
    public class Conta_Tipo : EntityBase
    {

        public string Descricao { get; set; }

        public bool IsCompany { get; set; }

        public bool IsUser { get; set; }

        public ICollection<Conta> Contas { get; set; }

    }
}
