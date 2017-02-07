using Project.Pizzaria.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Pizzaria.Application.Interfaces
{
    public interface IConta_TipoAppService : IDisposable
    {

        Conta_TipoViewModel Add(Conta_TipoViewModel Conta_TipoViewModel);

        Conta_TipoViewModel GetById(Guid id);

        Conta_TipoViewModel Update(Conta_TipoViewModel Conta_TipoViewModel);

        Conta_TipoViewModel Activate(Conta_TipoViewModel Conta_TipoViewModel);

        Conta_TipoViewModel Disable(Conta_TipoViewModel Conta_TipoViewModel);

        IEnumerable<Conta_TipoViewModel> GetAllActives();

        int Remove(Conta_TipoViewModel bairroViewModel);

    }
}
