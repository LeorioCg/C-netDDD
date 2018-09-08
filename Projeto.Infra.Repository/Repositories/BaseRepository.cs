using Projeto.Domain.Contracts;
using Projeto.Infra.Repository.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Infra.Repository.Repositories
{
    public abstract class BaseRepository<TEntity>
        : IBaseRepository<TEntity>
        where TEntity : class
    {
        private readonly DataContext context;

        public BaseRepository(DataContext context)
        {
            this.context = context;
        }

        public void Insert(TEntity obj)
        {
            context.Entry(obj).State = EntityState.Added;
            context.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            context.Entry(obj).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(TEntity obj)
        {
            context.Entry(obj).State = EntityState.Deleted;
            context.SaveChanges();
        }

        public List<TEntity> FindAll()
        {
            return context.Set<TEntity>().ToList();
        }

        public TEntity FindById(int id)
        {
            return context.Set<TEntity>().Find(id);
        }
                
    }
}