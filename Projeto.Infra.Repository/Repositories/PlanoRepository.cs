using Projeto.Domain.Contracts;
using Projeto.Domain.Entities;
using Projeto.Infra.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Infra.Repository.Repositories
{
    public class PlanoRepository
        : BaseRepository<Plano>, IPlanoRepository
    {
        private readonly DataContext context;

        public PlanoRepository(DataContext context)
            :base(context)
        {
            this.context = context;
        }
    }
}
