using Project.Pizzaria.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Pizzaria.Domain.Models;
using Project.Pizzaria.Domain.Interfaces.Repository;

namespace Project.Pizzaria.Domain.Services
{
    public class ContaService : IContaService
    {

        public readonly IContaRepository _contaRepository;

        public ContaService(IContaRepository contaRepository)
        {
            this._contaRepository = contaRepository;
        }

        public Conta Activate(Conta Conta)
        {
            return _contaRepository.Activate(Conta);
        }

        public Conta Add(Conta Conta)
        {
            return _contaRepository.Add(Conta);
            
        }

        public Conta Disable(Conta Conta)
        {
            return _contaRepository.Disable(Conta);
        }

        public void Dispose()
        {
            _contaRepository.Dispose();
        }

        public Conta GetById(Guid Id)
        {
            return _contaRepository.GetById(Id);
        }

        public void Remove(Conta Conta)
        {
            _contaRepository.Remove(Conta);
        }

        public Conta ReturnEntityDeleted(Conta Conta)
        {
            return _contaRepository.ReturnEntityDeleted(Conta);
        }


        public Conta Update(Conta Conta)
        {
           return _contaRepository.Update(Conta);
        }
    }
}
