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
    public class ItensController : ApiController
    {
        private ItemService service = new ItemService();


        // GET: api/Categories
        public ItemListAPIModel Get()
        {
            var apiModel = new ItemListAPIModel();

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
        public ItemAPIModel Get(long? id)
        {
            var apiModel = new ItemAPIModel();

            try
            {
                if (id == null)
                    apiModel.Message = "!OK";
                else
                {
                    

                }
            }
            catch (System.Exception)
            {
                apiModel.Message = "!OK";
            }

            return apiModel;
        }

        // POST: api/Categories
        public void Post([FromBody]Item value)
        { service.Save(value); }

        // PUT: api/Categories/5
        public void Put(int id, [FromBody]Item value)
        { service.Save(value); }

        // DELETE: api/Categories/5
        public void Delete(int id)
        { service.Delete(id); }

    }
}
