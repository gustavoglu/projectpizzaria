using Project.Pizzaria.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Pizzaria.Application.Interfaces
{
    public interface IUfAppService : IDisposable
    {
        UfViewModel Add(UfViewModel ufViewModel);

        UfViewModel GetById(Guid id);

        UfViewModel Update(UfViewModel ufViewModel);

        UfViewModel Activate(UfViewModel ufViewModel);

        UfViewModel Disable(UfViewModel ufViewModel);

        IEnumerable<UfViewModel> GetAllActives();

        int Remove(UfViewModel bairroViewModel);
    }
}
