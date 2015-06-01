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
    public class GrupoController : Controller
    {
        private PollaEntities db = new PollaEntities();

        //
        // GET: /Grupo/

        public ActionResult Index()
        {
            return View(db.Grupo.ToList());
        }

        //
        // GET: /Grupo/Details/5

        public ActionResult Details(int id = 0)
        {
            Grupo grupo = db.Grupo.Find(id);
            if (grupo == null)
            {
                return HttpNotFound();
            }
            return View(grupo);
        }

        //
        // GET: /Grupo/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Grupo/Create

        [HttpPost]
        public ActionResult Create(Grupo grupo)
        {
            if (ModelState.IsValid)
            {
                db.Grupo.Add(grupo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(grupo);
        }

        //
        // GET: /Grupo/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Grupo grupo = db.Grupo.Find(id);
            if (grupo == null)
            {
                return HttpNotFound();
            }
            return View(grupo);
        }

        //
        // POST: /Grupo/Edit/5

        [HttpPost]
        public ActionResult Edit(Grupo grupo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(grupo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(grupo);
        }

        //
        // GET: /Grupo/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Grupo grupo = db.Grupo.Find(id);
            if (grupo == null)
            {
                return HttpNotFound();
            }
            return View(grupo);
        }

        //
        // POST: /Grupo/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Grupo grupo = db.Grupo.Find(id);
            db.Grupo.Remove(grupo);
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