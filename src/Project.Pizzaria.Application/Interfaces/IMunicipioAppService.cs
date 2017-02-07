using Project.Pizzaria.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Pizzaria.Application.Interfaces
{
    public interface IMunicipioAppService : IDisposable
    {
        MunicipioViewModel Add(MunicipioViewModel municipioViewModel);

        MunicipioViewModel GetById(Guid id);

        MunicipioViewModel Update(MunicipioViewModel municipioViewModel);

        MunicipioViewModel Activate(MunicipioViewModel municipioViewModel);

        MunicipioViewModel Disable(MunicipioViewModel municipioViewModel);

        IEnumerable<MunicipioViewModel> GetAllActives();

        int Remove(MunicipioViewModel bairroViewModel);

        void Dispose();
    }
}
