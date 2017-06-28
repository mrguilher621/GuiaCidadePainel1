using GuiaCidadePainel.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using GuiaCidadePainel.Models;
using System.Net;

namespace GuiaCidadePainel.Controllers
{
    public class ItensController : Controller
    {
        private EFContext context = new EFContext();

        // GET: Itens
        public	ActionResult Index(){
            var itens = context.Itens.Include(c => c.Categoria).OrderBy(n => n.Nome);
            return View(itens);
        }
        // Create
        public ActionResult Create() {
            ViewBag.CategoriaId = new SelectList(context.Categorias.OrderBy(b => b.Nome), 
                "CategoriaId", "Nome");
             return View();
        }

        [HttpPost] public ActionResult Create(Item item) {
            try {
                context.Itens.Add(item);
                context.SaveChanges(); return RedirectToAction("Index");
            }
            catch {
                return View(item);
            }
        }
        // Edit
        public ActionResult Edit(long? id) {
            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = context.Itens.Find(id); if (item == null) {
                return HttpNotFound();
            }
            ViewBag.CategoriaId = new SelectList(context.Categorias.OrderBy(b => b.Nome), "CategoriaId", "Nome", item.CategoriaId);
            return View(item);
        }

        [HttpPost]
        public ActionResult Edit(Item item)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    context.Entry(item).State = EntityState.Modified;
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(item);
            }
            catch {
                return View(item);
            }
        }

        // Details
         public	ActionResult Details(long?	id) {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item	=	context.Itens.Where(p	=>	p.ItemId	==	   id)
                .Include(c	=>	c.Categoria).First();
            if	(item	==	null){
                return	HttpNotFound();
            }
            return	View(item);
        }
        // Delete
        public ActionResult Delete(long? id) {
            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = context.Itens.Where(p => p.ItemId == id)
                .Include(c => c.Categoria).First();
            if (item == null) {
                return HttpNotFound();
            }
            return View(item);
        }

        [HttpPost]
        public ActionResult Delete(long id)
        {
            try
            {
                Item item = context.Itens.Find(id); context.Itens.Remove(item);
                context.SaveChanges();
                TempData["Message"] = "Item" + item.Nome.ToUpper()

                        + "	foi	removido"; return RedirectToAction("Index");
            }
            catch {
                return View();
            }
        }





    }
}
