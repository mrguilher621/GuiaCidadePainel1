using GuiaCidadePainel.Models;
using GuiaCidadePainel.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GuiaCidadePainel.Controllers.Api
{
    public class CategoriasController : ApiController
    {
        private CategoriaService service = new CategoriaService();
      

        // GET: api/Categories
        public CategoriaListAPIModel Get()
        {
            var apiModel = new CategoriaListAPIModel();

            try
            {
                apiModel.Result = service.Get().ToList();
            }
            catch (System.Exception)
            {
                apiModel.Message = "!OK";
            }

            return apiModel;
        }

        // GET: api/Categories/5
        public CategoriaAPIModel Get(long? id)
        {
            var apiModel = new CategoriaAPIModel();

            try
            {
                if (id == null)
                    apiModel.Message = "!OK";
                else
                {
                    apiModel.Result = service.ById(id.Value);
                   
                }
            }
            catch (System.Exception)
            {
                apiModel.Message = "!OK";
            }

            return apiModel;
        }

        // POST: api/Categories
        public void Post([FromBody]Categoria value)
        { service.Save(value); }

        // PUT: api/Categories/5
        public void Put(int id, [FromBody]Categoria value)
        { service.Save(value); }

        // DELETE: api/Categories/5
        public void Delete(int id)
        { service.Delete(id); }
    
}
}
