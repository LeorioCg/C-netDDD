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
    [RoutePrefix("api/plano")]
    public class PlanoController : ApiController
    {
        private readonly IPlanoAplicationService service;

        public PlanoController(IPlanoAplicationService service)
        {
            this.service = service;
        }

        [HttpPost]
        [Route("cadastrar")] //URL: /api/plano/cadastrar
        public HttpResponseMessage Post(PlanoCadastroViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    service.Cadastrar(model);
                    return Request.CreateResponse(HttpStatusCode.OK, "Plano cadastradado com sucesso.");
                }
                catch(Exception e)
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
                }
                
            }
            else
            {
                //RETORNA ERRO 403...
                return Request.CreateResponse(HttpStatusCode.Forbidden, ModelState);
            }
        }

        [HttpPut]
        [Route("atualizar")] //URL: /api/plano/atualizar
        public HttpResponseMessage Put(PlanoEdicaoViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    service.Atualizar(model);
                    return Request.CreateResponse(HttpStatusCode.OK, "Plano atualizado com sucesso.");
                }
                catch(Exception e)
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
                }                
            }
            else
            {
                //RETORNA ERRO 403...
                return Request.CreateResponse(HttpStatusCode.Forbidden, ModelState);
            }
        }

        [HttpDelete]
        [Route("excluir")] //URL: /api/plano/excluir
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                service.Excluir(id);
                return Request.CreateResponse(HttpStatusCode.OK, "Plano excluido com sucesso.");
            }
            catch(Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }           
        }

        [HttpGet]
        [Route("obtertodos")] //URL: /api/plano/obtertodos
        public HttpResponseMessage GetAll()
        {
            try
            {
                List<PlanoConsultaViewModel> lista = service.ObterTodos();
                return Request.CreateResponse(HttpStatusCode.OK, lista);
            }
            catch(Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet]
        [Route("obterporid")]
        public HttpResponseMessage GetbyId(int id)
        {
            try
            {
                PlanoConsultaViewModel model = service.ObterporId(id);
                return Request.CreateResponse(HttpStatusCode.OK, model);
            }
            catch(Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
