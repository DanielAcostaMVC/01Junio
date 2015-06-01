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
    public class EquipoPartidoController : Controller
    {
        private PollaEntities db = new PollaEntities();

        //
        // GET: /EquipoPartido/

        public ActionResult Index()
        {
            var equipopartido = db.EquipoPartido.Include(e => e.Equipo).Include(e => e.Partido);
            return View(equipopartido.ToList());
        }

        //
        // GET: /EquipoPartido/Details/5

        public ActionResult Details(int id = 0)
        {
            EquipoPartido equipopartido = db.EquipoPartido.Find(id);
            if (equipopartido == null)
            {
                return HttpNotFound();
            }
            return View(equipopartido);
        }

        //
        // GET: /EquipoPartido/Create

        public ActionResult Create()
        {
            ViewBag.IdEquipo = new SelectList(db.Equipo, "IdEquipo", "Nombre");
            ViewBag.IdPartido = new SelectList(db.Partido, "IdPartido", "Descripcion");
            return View();
        }

        //
        // POST: /EquipoPartido/Create

        [HttpPost]
        public ActionResult Create(EquipoPartido equipopartido)
        {
            if (ModelState.IsValid)
            {
                db.EquipoPartido.Add(equipopartido);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdEquipo = new SelectList(db.Equipo, "IdEquipo", "Nombre", equipopartido.IdEquipo);
            ViewBag.IdPartido = new SelectList(db.Partido, "IdPartido", "Descripcion", equipopartido.IdPartido);
            return View(equipopartido);
        }

        //
        // GET: /EquipoPartido/Edit/5

        public ActionResult Edit(int id = 0)
        {
            EquipoPartido equipopartido = db.EquipoPartido.Find(id);
            if (equipopartido == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdEquipo = new SelectList(db.Equipo, "IdEquipo", "Nombre", equipopartido.IdEquipo);
            ViewBag.IdPartido = new SelectList(db.Partido, "IdPartido", "Descripcion", equipopartido.IdPartido);
            return View(equipopartido);
        }

        //
        // POST: /EquipoPartido/Edit/5

        [HttpPost]
        public ActionResult Edit(EquipoPartido equipopartido)
        {
            if (ModelState.IsValid)
            {
                db.Entry(equipopartido).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdEquipo = new SelectList(db.Equipo, "IdEquipo", "Nombre", equipopartido.IdEquipo);
            ViewBag.IdPartido = new SelectList(db.Partido, "IdPartido", "Descripcion", equipopartido.IdPartido);
            return View(equipopartido);
        }

        //
        // GET: /EquipoPartido/Delete/5

        public ActionResult Delete(int id = 0)
        {
            EquipoPartido equipopartido = db.EquipoPartido.Find(id);
            if (equipopartido == null)
            {
                return HttpNotFound();
            }
            return View(equipopartido);
        }

        //
        // POST: /EquipoPartido/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            EquipoPartido equipopartido = db.EquipoPartido.Find(id);
            db.EquipoPartido.Remove(equipopartido);
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