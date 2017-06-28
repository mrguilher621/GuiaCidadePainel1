using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuiaCidadePainel.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public String Nome { get; set; }
        public virtual ICollection<Item> Itens { get; set; }
    }
}