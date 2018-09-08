using Projeto.Aplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Aplication.Contracts
{
    public interface IPlanoAplicationService
    {
        void Cadastrar(PlanoCadastroViewModel model);
        void Atualizar(PlanoEdicaoViewModel model);
        void Excluir(int IdPlano);
        List<PlanoConsultaViewModel> ObterTodos();
        PlanoConsultaViewModel ObterporId(int idPlano);
    }
}
