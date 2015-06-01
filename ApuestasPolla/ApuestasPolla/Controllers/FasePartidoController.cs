using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ApuestasPolla.Models;

namespace ApuestasPolla.Controllers
{
    public class FasePartidoController : Controller
    {
        private PollaEntities db = new PollaEntities();

        //
        // GET: /FasePartido/

        public ActionResult Index()
        {
            return View(db.FasePartido.ToList());
        }

        //
        // GET: /FasePartido/Details/5

        public ActionResult Details(int id = 0)
        {
            FasePartido fasepartido = db.FasePartido.Find(id);
            if (fasepartido == null)
            {
                return HttpNotFound();
            }
            return View(fasepartido);
        }

        //
        // GET: /FasePartido/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /FasePartido/Create

        [HttpPost]
        public ActionResult Create(FasePartido fasepartido)
        {
            if (ModelState.IsValid)
            {
                db.FasePartido.Add(fasepartido);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fasepartido);
        }

        //
        // GET: /FasePartido/Edit/5

        public ActionResult Edit(int id = 0)
        {
            FasePartido fasepartido = db.FasePartido.Find(id);
            if (fasepartido == null)
            {
                return HttpNotFound();
            }
            return View(fasepartido);
        }

        //
        // POST: /FasePartido/Edit/5

        [HttpPost]
        public ActionResult Edit(FasePartido fasepartido)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fasepartido).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fasepartido);
        }

        //
        // GET: /FasePartido/Delete/5

        public ActionResult Delete(int id = 0)
        {
            FasePartido fasepartido = db.FasePartido.Find(id);
            if (fasepartido == null)
            {
                return HttpNotFound();
            }
            return View(fasepartido);
        }

        //
        // POST: /FasePartido/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            FasePartido fasepartido = db.FasePartido.Find(id);
            db.FasePartido.Remove(fasepartido);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}