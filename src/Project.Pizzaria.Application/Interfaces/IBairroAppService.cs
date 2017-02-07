using Project.Pizzaria.Application.Interfaces;
using Project.Pizzaria.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Pizzaria.Application.Interfaces
{
   public interface IBairroAppService : IDisposable
    {
        BairroViewModel Add(BairroViewModel bairroViewModel);

        BairroViewModel GetById(Guid id);

        BairroViewModel Update(BairroViewModel bairroViewModel);

        BairroViewModel Activate(BairroViewModel bairroViewModel);

        BairroViewModel Disable(BairroViewModel bairroViewModel);

        IEnumerable<BairroViewModel> GetAllActives();

        int Remove(BairroViewModel bairroViewModel);

    }
}
