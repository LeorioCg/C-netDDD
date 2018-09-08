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
    public class ClienteRepository
        : BaseRepository<Cliente>, IClienteRepository
    {
        private readonly DataContext context;

        public ClienteRepository(DataContext context)
            :base(context)
        {
            this.context = context;
        }
    }
}
