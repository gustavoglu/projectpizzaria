using Project.Pizzaria.Domain.Interfaces.Services;
using Project.Pizzaria.Domain.Services;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Pizzaria.CrossCutting.IoC
{
   public class BootStrepper
    {
        public void Register(Container container)
        {
            container.Register<IProdutoService, ProdutoService>(Lifestyle.Scoped);

            container.Register<IContaService, ContaService>(Lifestyle.Scoped);
        }
    }
}
