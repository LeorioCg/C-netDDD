using Projeto.Aplication.ViewModels;
using Projeto.Domain.Contracts;
using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Aplication.AplicationServices
{
    public class ClienteAplicationService
    {
        private readonly IClienteDomainService domainService;

        public ClienteAplicationService(IClienteDomainService domainService)
        {
            this.domainService = domainService;
        }

        public void Cadastrar(ClienteCadastroViewModel model)
        {
            Cliente c = new Cliente();
            c.Nome = model.Nome;
            c.Email = model.Email;
            c.DataNascimento = model.DataNascimento;
            c.IdPlano = model.IdPlano;

            domainService.Cadastrar(c);
        }

        public void Atualizar(ClienteEdicaoViewModel model)
        {
            Cliente c = domainService.ObterporId(model.IdCliente);
            c.Nome = model.Nome;
            c.Email = model.Email;
            c.DataNascimento = model.DataNascimento;
            c.IdPlano = model.IdPlano;

            domainService.Alterar(c);
        }

        public void Excluir(int idCliente)
        {
            Cliente c = domainService.ObterporId(idCliente);
            domainService.Excluir(c);
        }

        public List<ClienteConsultaViewModel> ObterTodos()
        {
            List<Cliente> clientes = new List<Cliente>();
        }
    }
}
