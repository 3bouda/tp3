using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tp3.Models;

namespace tp3.Controllers
{
    public class ProduitController : Controller
    {
        // GET: Produit
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            ViewBag.Message = "Hello to the home page of TP3";
            return View();
        }
        public ActionResult DisplayOneProduct()
        {
            var produit = new Produit
            {
                Id = 1,
                Name = "Produit Exemple",
                Prix = 99.99
            };

            return View(produit);
        }
        public ActionResult DisplayManyProducts()
        {
            var produits = new List<Produit>
            {
                new Produit { Id = 1, Name = "Produit 1", Prix = 19.99 },
                new Produit { Id = 2, Name = "Produit 2", Prix = 29.99 },
                new Produit { Id = 3, Name = "Produit 3", Prix = 39.99 }
            };
            ViewData["Produits"] = produits;
            return View();
        }
    }
}