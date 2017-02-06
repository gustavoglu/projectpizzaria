using Project.Pizzaria.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Pizzaria.Application.Interfaces
{
    interface IContaAppService : IDisposable
    {
        Conta_ContaTipo_EnderecoViewModel Add(Conta_ContaTipo_EnderecoViewModel conta_ContaTipo_EnderecoViewModel);

        ContaViewModel GetById(Guid id);

        ContaViewModel Update(ContaViewModel contaViewModel);

        ContaViewModel Activate(ContaViewModel contaViewModel);

        ContaViewModel Disable(ContaViewModel contaViewModel);

        IEnumerable<ContaViewModel> GetAllActives();

        int Remove(ContaViewModel contaViewModel);
    }
}
