using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Project.Pizzaria.Application.ViewModels
{
    public class Produto_TipoViewModel
    {
        [Key]
        public Guid Id{ get; set; }

        [Required(ErrorMessage = "Necessário informar a Descrição")]
        public string Descricao { get; set; }

        public ICollection<ProdutoViewModel> Produtos { get; set; }

        public Produto_TipoViewModel()
        {
            this.Produtos = new List<ProdutoViewModel>();
        }
    }
}