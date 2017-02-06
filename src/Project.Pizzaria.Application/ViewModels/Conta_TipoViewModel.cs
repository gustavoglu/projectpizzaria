using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Project.Pizzaria.Application.ViewModels
{
    public class Conta_TipoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage ="É Necessário informar a descrição")]
        public string Descricao { get; set; }

        public bool IsCompany { get; set; }

        public bool IsUser { get; set; }

        public ICollection<ContaViewModel> Contas { get; set; }

        public Conta_TipoViewModel()
        {
            this.Contas = new List<ContaViewModel>();  
        }
    }
}