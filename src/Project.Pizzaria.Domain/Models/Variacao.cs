

using System;

namespace Project.Pizzaria.Domain.Models
{
    
    public class Variacao
    {
    
        public Guid Id_variacao { get; set; }

        public string Descricao { get; set; }

        public double Valor { get; set; }

        public Variacao_Tipo Variacao_tipo { get; set; }

    }
}
