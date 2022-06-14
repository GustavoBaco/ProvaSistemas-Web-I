using Prova.Context;
using Prova.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Prova.Controllers
{
    public class ProdutoController : Controller
    {
        private Contexto db = new Contexto();
        // GET: Produto
        public ActionResult Index()
        {
            return View(db.Produto.ToList());
        }
        //GET: Create
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProdutoModel produtoModel)
        {
            if (ModelState.IsValid)
            {
                db.Produto.Add(produtoModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(produtoModel);
        }

        //Get Delete
        public ActionResult Delete(long? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProdutoModel produtoModel = db.Produto.Find(id);
            if(produtoModel == null)
            {
                return HttpNotFound();
            }
            return View(produtoModel);
        }

        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            ProdutoModel produtoModel = db.Produto.Find(id);
            db.Produto.Remove(produtoModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}