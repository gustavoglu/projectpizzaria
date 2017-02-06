using System;
using System.Collections.Generic;

namespace Project.Pizzaria.Domain.Models
{

    public class Conta : EntityBase
    {
     
        public string Nome { get; set; }

        public Guid Id_endereco { get; set; }

        public Guid Id_Conta_Tipo{ get; set; }

        public DateTime Aniversario{ get; set; }

        public string Email{ get; set; }

        public Conta_Tipo Conta_Tipo { get; set; }

        public ICollection<Endereco> Enderecos{ get; set; }
        

    }
}
