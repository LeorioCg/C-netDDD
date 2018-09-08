using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Domain.Contracts
{
    public interface IBaseDomainService<TEntity>
        where TEntity : class
    {
        void Cadastrar(TEntity obj);
        void Alterar(TEntity obj);
        void Excluir(TEntity obj);
        List<TEntity> ObterTodos();
        TEntity ObterporId(int id);
    }
}
