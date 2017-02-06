using Project.Pizzaria.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Pizzaria.Application.ViewModels
{
   public class ContaViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength (100,ErrorMessage = "Nome muito grande para ser inserido")]
        [MinLength(2, ErrorMessage = "Nome muito pequeno para ser inserido")]
        public string Nome { get; set; }

        public DateTime Aniversario { get; set; }

        [MaxLength(100, ErrorMessage = "Email muito grande para ser inserido")]
        public string Email { get; set; }

        public Conta_TipoViewModel Conta_Tipo { get; set; }

        public ICollection<EnderecoViewModel> Enderecos { get; set; }

        public ContaViewModel()
        {
            this.Enderecos = new List<EnderecoViewModel>();
        }

    }
}
