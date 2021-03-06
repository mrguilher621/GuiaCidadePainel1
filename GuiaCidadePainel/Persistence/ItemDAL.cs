﻿using GuiaCidadePainel.Contexts;
using GuiaCidadePainel.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GuiaCidadePainel.Persistence
{
    public class ItemDAL
    {
        private EFContext context = new EFContext();

        public IQueryable<Item> Get()
        {
            return context.Itens;
        }

        public IQueryable<Item> GetOrderedByName()
        {
            return context
                .Itens
                .Include(p => p.Categoria)           
                .OrderBy(b => b.Nome);
        }

        public Item ById(long id)
        {
            return context.Itens
                .Where(p => p.ItemId == id)
                .Include(c => c.Categoria)
                .First();
        }

        public IQueryable<Item> GetByCategory(long categoriaId)
        {
            return context
                .Itens
                .Where(p => p.CategoriaId.HasValue &&
                p.CategoriaId.Value == categoriaId);
        }

        public void Save(Item item)
        {
            if (item.ItemId == null)
                context.Itens.Add(item);
            else
                context.Entry(item).State = EntityState.Modified;

            context.SaveChanges();
        }

        public Item Delete(long id)
        {
            var item = ById(id);

            context.Itens.Remove(item);
            context.SaveChanges();

            return item;
        }
    }
}
