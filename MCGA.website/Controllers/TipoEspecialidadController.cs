using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MCGA.Data;
using MCGA.Entities;

namespace MCGA.website.Controllers
{
    public class TipoEspecialidadController : Controller
    {
        private MCGA.UI.Process.TipoEspecialidadProcess tipoEsp = new MCGA.UI.Process.TipoEspecialidadProcess();



        private MedicureContext db = new MedicureContext();

        // GET: TipoEspecialidad
        public ActionResult Index()
        {
            //return View(db.TipoEspecialidad.ToList());
            return View(tipoEsp.component.ToList());
           
        }

        // GET: TipoEspecialidad/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
           TipoEspecialidad tipoEspecialidad = db.TipoEspecialidad.Find(id);
            //TipoEspecialidad tipoEspecialidad = tipoEsp.component.Find(id);
            if (tipoEspecialidad == null)
            {
                return HttpNotFound();
            }
            return View(tipoEspecialidad);
        }

        // GET: TipoEspecialidad/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoEspecialidad/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,descripcion")] TipoEspecialidad tipoEspecialidad)
        {
            if (ModelState.IsValid)
            {
                db.TipoEspecialidad.Add(tipoEspecialidad);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoEspecialidad);
        }

        // GET: TipoEspecialidad/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoEspecialidad tipoEspecialidad = db.TipoEspecialidad.Find(id);
            if (tipoEspecialidad == null)
            {
                return HttpNotFound();
            }
            return View(tipoEspecialidad);
        }

        // POST: TipoEspecialidad/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,descripcion")] TipoEspecialidad tipoEspecialidad)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoEspecialidad).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoEspecialidad);
        }

        // GET: TipoEspecialidad/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoEspecialidad tipoEspecialidad = db.TipoEspecialidad.Find(id);
            if (tipoEspecialidad == null)
            {
                return HttpNotFound();
            }
            return View(tipoEspecialidad);
        }

        // POST: TipoEspecialidad/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoEspecialidad tipoEspecialidad = db.TipoEspecialidad.Find(id);
            db.TipoEspecialidad.Remove(tipoEspecialidad);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
