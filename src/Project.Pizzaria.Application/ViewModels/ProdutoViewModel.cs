using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Pizzaria.Application.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage ="")]
        [MaxLength(100,ErrorMessage = "")]
        public string Descricao { get; set; }

        public int Codigo { get; set; }

        [Required(ErrorMessage = "")]
        [MaxLength(600, ErrorMessage = "")]
        public string Observacoes { get; set; }

        [ScaffoldColumn(false)]
        public Guid Id_Produto_tipo { get; set; }

        [MaxLength(1000, ErrorMessage = "")]
        public string ImagemUri { get; set; }
        
        public bool BaixaEstoque { get; set; }

        public bool VenderSemEstoque { get; set; }

        public double Saldo { get; set; }


    }
}
