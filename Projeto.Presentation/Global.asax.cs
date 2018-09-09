using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using Projeto.Aplication.AplicationServices;
using Projeto.Aplication.Contracts;
using Projeto.Domain.Contracts;
using Projeto.Domain.Services;
using Projeto.Infra.Repository.Context;
using Projeto.Infra.Repository.Repositories;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using SimpleInjector.Lifestyles;

namespace Projeto.Presentation
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            // Create the container as usual.
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            // Register your types, for instance using the scoped lifestyle:
            container.Register<IClienteAplicationService, ClienteAplicationService>(Lifestyle.Scoped);
            container.Register<IPlanoAplicationService, PlanoAplicationService>(Lifestyle.Scoped);

            container.Register<IClienteDomainService, ClienteDomainService>(Lifestyle.Scoped);
            container.Register<IPlanoDomainService, PlanoDomainService>(Lifestyle.Scoped);

            container.Register<IClienteRepository, ClienteRepository>(Lifestyle.Scoped);
            container.Register<IPlanoRepository, PlanoRepository>(Lifestyle.Scoped);

            container.Register<DataContext>(Lifestyle.Scoped);


            // This is an extension method from the integration package.
            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            container.Verify();

            GlobalConfiguration.Configuration.DependencyResolver =
                new SimpleInjectorWebApiDependencyResolver(container);

            // Here your usual Web API configuration stuff.

        }
    }
}
