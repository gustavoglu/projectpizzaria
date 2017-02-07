using Project.Pizzaria.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Pizzaria.Application.ViewModels;
using Project.Pizzaria.Domain.Interfaces.Repository;
using Project.Pizzaria.Infra.Data.Repository;
using AutoMapper;
using Project.Pizzaria.Domain.Models;

namespace Project.Pizzaria.Application.Services
{
    public class ContaAppService : IContaAppService
    {
        private readonly IContaRepository _contaRepository;

        public ContaAppService()
        {
            this._contaRepository = new ContaRepository();
        }
      
        public Conta_ContaTipo_EnderecoViewModel Add(Conta_ContaTipo_EnderecoViewModel conta_ContaTipo_EnderecoViewModel)
        {
            var conta = Mapper.Map<Conta>(conta_ContaTipo_EnderecoViewModel.ContaViewModel);
            var conta_tipo = Mapper.Map<Conta_Tipo>(conta_ContaTipo_EnderecoViewModel.Conta_TipoViewModel);
            var enderecos = Mapper.Map<IEnumerable<Endereco>>(conta_ContaTipo_EnderecoViewModel.ContaViewModel);

            foreach (var endereco in enderecos)
            {
                conta.Enderecos.Add(endereco);
            }

            conta.Active = true;

            if (conta_tipo != null)
            {
                conta.Conta_Tipo = conta_tipo;
            }

            _contaRepository.Add(conta);

            return conta_ContaTipo_EnderecoViewModel;
        }

        public ContaViewModel Activate(ContaViewModel contaViewModel)
        {
            _contaRepository.Activate(Mapper.Map<Conta>(contaViewModel));

            return contaViewModel;
        }


        public ContaViewModel Disable(ContaViewModel contaViewModel)
        {
            _contaRepository.Disable(Mapper.Map<Conta>(contaViewModel));

            return contaViewModel;
        }

        public void Dispose()
        {
            _contaRepository.Dispose();
        }

        public IEnumerable<ContaViewModel> GetAllActives()
        {
            return Mapper.Map<IEnumerable<ContaViewModel>> (_contaRepository.GetAllActives());
        }

        public ContaViewModel GetById(Guid id)
        {
            return Mapper.Map<ContaViewModel>(_contaRepository.GetById(id));
        }

        public int Remove(ContaViewModel contaViewModel)
        {
            var conta = Mapper.Map<Conta>(contaViewModel);
             return _contaRepository.Remove(conta);
        }

        public ContaViewModel Update(ContaViewModel contaViewModel)
        {
             _contaRepository.Update(Mapper.Map<Conta>(contaViewModel));
            return contaViewModel;
        }

  

    }
}
