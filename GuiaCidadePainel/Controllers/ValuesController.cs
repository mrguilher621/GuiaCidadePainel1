﻿using GuiaCidadePainel.Contexts;
using GuiaCidadePainel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace GuiaCidadePainel.Controllers
{
    public class ValuesController : ApiController
    {
        private EFContext context = new EFContext();

        // GET api/values
        public IEnumerable<Item> Get()
        {
            //return new string[] { "value1", "value2" };
            return context.Itens.ToList();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
