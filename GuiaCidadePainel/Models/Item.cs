using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuiaCidadePainel.Models
{
    public class Item
    {
        public long? ItemId { get; set; }
        public string Nome { get; set; }
        public long? CategoriaId { get; set; }        
        public Categoria Categoria { get; set; }    
    }
}