using Projeto.Aplication.Contracts;
using Projeto.Aplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Projeto.Presentation.Controllers
{
    [RoutePrefix("api/cliente")]
    public class ClienteController : ApiController
    {
        private readonly IClienteAplicationService service;

        public ClienteController(IClienteAplicationService service)
        {
            this.service = service;
        }

        [HttpPost]
        [Route("cadastrar")]
        public HttpResponseMessage Post(ClienteCadastroViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    service.Cadastrar(model);

                    return Request.CreateResponse(HttpStatusCode.OK, "Cliente cadastrado com sucesso");
                }
                catch(Exception e)
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
                }
                
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.Forbidden, ModelState);
            }
        }

        [HttpPut]
        [Route("atualizar")]
        public HttpResponseMessage Put(ClienteEdicaoViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    service.Atualizar(model);
                    return Request.CreateResponse(HttpStatusCode.OK, "Cliente atualizado com sucesso");
                }
                catch(Exception e)
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
                }                
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.Forbidden, ModelState);
            }
        }

        [HttpDelete]
        [Route("deletar")]
        public HttpResponseMessage Delete(int id)
        {
            service.Excluir(id);
            return Request.CreateResponse(HttpStatusCode.OK, "Cliente excluído com sucesso");
        }

        [HttpGet]
        [Route("obtertodos")]
        public HttpResponseMessage GetAll()
        {
            List<ClienteConsultaViewModel> lista = service.ObterTodos();
            return Request.CreateResponse(HttpStatusCode.OK, lista);
        }

        [HttpGet]
        [Route("obterporid")]
        public HttpResponseMessage GetbyId(int id)
        {
            try
            {
                ClienteConsultaViewModel model = service.ObterPorId(id);
                return Request.CreateResponse(HttpStatusCode.OK, model);
            }
            catch(Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
            
        }
    }
}
