using System;

namespace Project.Pizzaria.Domain.Models
{
    public class Endereco : EntityBase
    {

        public Guid Id_Bairro { get; set; }

        public Guid Id_Municipio { get; set; }

        public Guid Id_Conta { get; set; }

        public Guid Id_Uf { get; set; }

        public string Rua { get; set; }

        public int Numero { get; set; }

        public string Telefone1 { get; set; }

        public string Telefone2 { get; set; }

        public string Complemento { get; set; }

        public virtual Bairro Bairro { get; set; }

        public virtual Municipio Municipio { get; set; }

        public virtual Uf Uf { get; set; }

        public virtual Conta Conta { get; set; }

    }

}
