using Projeto.Domain.Contracts;
using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Domain.Services
{
    public class PlanoDomainService : BaseDomainService<Plano>, IPlanoDomainService
    {
        private readonly IPlanoRepository repository;

        public PlanoDomainService(IPlanoRepository repository)
            : base(repository)
        {
            this.repository = repository;
        }
            
    }
}
