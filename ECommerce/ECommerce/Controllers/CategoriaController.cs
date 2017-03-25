using ECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerce.Controllers
{
    [Authorize]
    public class CategoriaController : Controller
    {
        [HttpPost]
        public ActionResult Listar()
        {
            var cat = new List<CategoriaViewModel>();
            using (var entities = new ECommerceEntities())
            {
                cat = entities.Categorias.Select(i => new CategoriaViewModel() {
                    Categoria = i.Categoria,
                    Id = i.Id,
                    Seleccionada = false
                }).ToList();
            }
            var a = PartialView("_ListaCategorias", cat);
            return a;
        }
    }
}