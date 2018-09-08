using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Domain.Contracts;
using Projeto.Domain.Entities;
using Projeto.Aplication.ViewModels;
using Projeto.Domain.Services;

namespace Projeto.Aplication.AplicationServices
{
    class PlanoAplicationService
    {
        private readonly IPlanoDomainService domainService;

        public PlanoAplicationService(IPlanoDomainService domainService)
        {
            this.domainService = domainService;
        }

        public void Cadastrar(PlanoCadastroViewModel model)
        {
            Plano p = new Plano();
            p.Descricao = model.Descricao;
        }

        public void Alterar(PlanoEdicaoViewModel model)
        {
            Plano p = domainService.ObterporId(model.IdPlano);
            p.Descricao = model.Descricao;

            domainService.Alterar(p);
        }

        public void Excluir(int idPlano)
        {
            Plano p = domainService.ObterporId(idPlano);
            domainService.Excluir(p);
        }

        public List<PlanoConsultaViewModel> ObterTodos()
        {
            List<Plano> planos = domainService.ObterTodos();

            List<PlanoConsultaViewModel> lista = new List<PlanoConsultaViewModel>();

            foreach(Plano p in planos)
            {
                PlanoConsultaViewModel model = new PlanoConsultaViewModel();
                model.IdPlano = p.IdPlano;
                model.Descricao = p.Descricao;
                model.QntClientes = p.Clientes.Count();

                lista.Add(model);
            }
            return lista;
        }

        public PlanoConsultaViewModel ObterporId(int idPlano)
        {
            Plano p = domainService.ObterporId(idPlano);

            PlanoConsultaViewModel model = new PlanoConsultaViewModel();
            model.IdPlano = p.IdPlano;
            model.Descricao = p.Descricao;
            model.QntClientes = p.Clientes.Count();

            return model;
        }
      
    }
}
