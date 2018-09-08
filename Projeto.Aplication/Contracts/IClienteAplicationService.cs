using Projeto.Aplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Aplication.Contracts
{
    public interface IClienteAplicationService
    {
        void Cadastrar(ClienteCadastroViewModel model);
        void Atualizar(ClienteEdicaoViewModel model);
        void Excluir(int idCliente);
        List<ClienteConsultaViewModel> ObterTodos();
        ClienteConsultaViewModel ObterPorId(int idCliente);
    }
}
