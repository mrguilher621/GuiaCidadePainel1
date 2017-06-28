using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuiaCidadePainel.Models
{
    public class ItemListAPIModel : APIModel
    {
        // { Message: "OK", Result: [{},{}] }
        public List<Item> Result
        { get; set; }
    }

    public class ItemAPIModel : APIModel
        {
            // { Message: "OK", Result: {} }
            public Categoria Result
            { get; set; }
        }
    
}