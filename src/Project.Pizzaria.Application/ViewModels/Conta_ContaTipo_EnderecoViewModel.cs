using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Pizzaria.Application.ViewModels
{
    public class Conta_ContaTipo_EnderecoViewModel
    {
        public ContaViewModel ContaViewModel  { get; set; }

        public Conta_TipoViewModel Conta_TipoViewModel { get; set; }

        public IEnumerable<EnderecoViewModel> EnderecosViewModel { get; set; }
    }
}
