﻿ using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ERP_ZORZAL.Models;

namespace ERP_ZORZAL.Controllers
{
    public class MonedaController : Controller
    {
        private ERP_ZORZALEntities db = new ERP_ZORZALEntities();

        // GET: /Moneda/
        public ActionResult Index()
        {
            var tbmoneda = db.tbMoneda.Include(t => t.tbUsuario).Include(t => t.tbUsuario1);
            return View(tbmoneda.ToList());
        }

        // GET: /Moneda/Details/5
        public ActionResult Details(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbMoneda tbMoneda = db.tbMoneda.Find(id);
            if (tbMoneda == null)
            {
                return HttpNotFound();
            }
            return View(tbMoneda);
        }

        // GET: /Moneda/Create
        public ActionResult Create()
        {
            ViewBag.mnda_UsuarioCrea = new SelectList(db.tbUsuario, "usu_Id", "usu_NombreUsuario");
            ViewBag.mnda_UsuarioModifica = new SelectList(db.tbUsuario, "usu_Id", "usu_NombreUsuario");
            return View();
        }

        // POST: /Moneda/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="mnda_Id,mnda_Abreviatura,mnda_Nombre,mnda_UsuarioCrea,mnda_FechaCrea,mnda_UsuarioModifica,mnda_FechaModifica")] tbMoneda tbMoneda)
        {
            if (ModelState.IsValid)
            {
                db.tbMoneda.Add(tbMoneda);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.mnda_UsuarioCrea = new SelectList(db.tbUsuario, "usu_Id", "usu_NombreUsuario", tbMoneda.mnda_UsuarioCrea);
            ViewBag.mnda_UsuarioModifica = new SelectList(db.tbUsuario, "usu_Id", "usu_NombreUsuario", tbMoneda.mnda_UsuarioModifica);
            return View(tbMoneda);
        }

        // GET: /Moneda/Edit/5
        public ActionResult Edit(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbMoneda tbMoneda = db.tbMoneda.Find(id);
            if (tbMoneda == null)
            {
                return HttpNotFound();
            }
            ViewBag.mnda_UsuarioCrea = new SelectList(db.tbUsuario, "usu_Id", "usu_NombreUsuario", tbMoneda.mnda_UsuarioCrea);
            ViewBag.mnda_UsuarioModifica = new SelectList(db.tbUsuario, "usu_Id", "usu_NombreUsuario", tbMoneda.mnda_UsuarioModifica);
            return View(tbMoneda);
        }

        // POST: /Moneda/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="mnda_Id,mnda_Abreviatura,mnda_Nombre,mnda_UsuarioCrea,mnda_FechaCrea,mnda_UsuarioModifica,mnda_FechaModifica")] tbMoneda tbMoneda)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbMoneda).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.mnda_UsuarioCrea = new SelectList(db.tbUsuario, "usu_Id", "usu_NombreUsuario", tbMoneda.mnda_UsuarioCrea);
            ViewBag.mnda_UsuarioModifica = new SelectList(db.tbUsuario, "usu_Id", "usu_NombreUsuario", tbMoneda.mnda_UsuarioModifica);
            return View(tbMoneda);
        }

        // GET: /Moneda/Delete/5
        public ActionResult Delete(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbMoneda tbMoneda = db.tbMoneda.Find(id);
            if (tbMoneda == null)
            {
                return HttpNotFound();
            }
            return View(tbMoneda);
        }

        // POST: /Moneda/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(short id)
        {
            tbMoneda tbMoneda = db.tbMoneda.Find(id);
            db.tbMoneda.Remove(tbMoneda);
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
