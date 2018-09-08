using Projeto.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Domain.Services
{
    public abstract class BaseDomainService<TEntity> 
        : IBaseDomainService<TEntity>
        where TEntity : class
    {
        private readonly IBaseRepository<TEntity> repository;

        protected BaseDomainService(IBaseRepository<TEntity> repository)
        {
            this.repository = repository;
        }

        public virtual void Cadastrar(TEntity obj)
        {
            repository.Insert(obj);
        }

        public virtual void Alterar(TEntity obj)
        {
            repository.Update(obj);
        }

        public virtual void Excluir(TEntity obj)
        {
            repository.Delete(obj);
        }

        public virtual List<TEntity> ObterTodos()
        {
            return repository.FindAll();
        }             

        public virtual TEntity ObterporId(int id)
        {
            return repository.FindById(id);
        }
    }
}
