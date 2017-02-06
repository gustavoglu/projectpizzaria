using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Project.Pizzaria.Application.ViewModels
{
    public class BairroViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O Campo descrição não pode ficar vazio")]
        [MaxLength(50, ErrorMessage = "Texto muito grande")]
        public string Descricao { get; set; }
     
        public double Taxa { get; set; }

        public ICollection<EnderecoViewModel> Enderecos { get; set; }

        public BairroViewModel()
        {
            this.Enderecos = new List<EnderecoViewModel>();        
        }
    }
}