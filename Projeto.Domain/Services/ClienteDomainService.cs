using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Domain.Contracts;
using Projeto.Domain.Entities;


namespace Projeto.Domain.Services
{
    public class ClienteDomainService : BaseDomainService<Cliente>, IClienteDomainService
    {
        //classes das regras de negócio...
        private readonly IClienteRepository repository;

        public ClienteDomainService(IClienteRepository repository)
            : base(repository)//construtor da SUPERCLASSE...
        {
            this.repository = repository;
        }
    }
}
