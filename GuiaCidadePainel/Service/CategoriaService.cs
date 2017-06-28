using GuiaCidadePainel.Models;
using GuiaCidadePainel.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuiaCidadePainel.Service
{
    public class CategoriaService
    {
        private CategoriaDAL dal = new CategoriaDAL();

        #region [ Get's ]

        public IQueryable<Categoria> Get()
        { return dal.Get(); }

        public IQueryable<Categoria> GetOrderedByName()
        { return dal.GetOrderedByName(); }

        public Categoria ById(long id)
        { return dal.ById(id); }

        #endregion [ Get's ]

        public void Save(Categoria item)
        { dal.Save(item); }

        public Categoria Delete(long id)
        { return dal.Delete(id); }
    }
}
