﻿using System;
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
    public class ListaPrecioController : Controller
    {
        private ERP_ZORZALEntities db = new ERP_ZORZALEntities();

        // GET: /ListaPrecio/
        public ActionResult Index()
        {
            var tblistaprecio = db.tbListaPrecio.Include(t => t.tbUsuario).Include(t => t.tbUsuario1).Include(t => t.tbListadoPrecioDetalle);
            return View(tblistaprecio.ToList());
        }

        // GET: /ListaPrecio/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbListaPrecio tbListaPrecio = db.tbListaPrecio.Find(id);
            if (tbListaPrecio == null)
            {
                return HttpNotFound();
            }
            return View(tbListaPrecio);
        }

        // GET: /ListaPrecio/Create
        public ActionResult Create()
        {
            ViewBag.listp_UsuarioCrea = new SelectList(db.tbUsuario, "usu_Id", "usu_NombreUsuario");
            ViewBag.listp_UsuarioModifica = new SelectList(db.tbUsuario, "usu_Id", "usu_NombreUsuario");
            ViewBag.listp_Id = new SelectList(db.tbListadoPrecioDetalle, "listp_Id", "prod_Codigo");
            return View();
        }

        // POST: /ListaPrecio/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="listp_Id,listp_EsActivo,listp_UsuarioCrea,listp_FechaCrea,listp_UsuarioModifica,listp_FechaModifica")] tbListaPrecio tbListaPrecio)
        {
            if (ModelState.IsValid)
            {
                db.tbListaPrecio.Add(tbListaPrecio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.listp_UsuarioCrea = new SelectList(db.tbUsuario, "usu_Id", "usu_NombreUsuario", tbListaPrecio.listp_UsuarioCrea);
            ViewBag.listp_UsuarioModifica = new SelectList(db.tbUsuario, "usu_Id", "usu_NombreUsuario", tbListaPrecio.listp_UsuarioModifica);
            ViewBag.listp_Id = new SelectList(db.tbListadoPrecioDetalle, "listp_Id", "prod_Codigo", tbListaPrecio.listp_Id);
            return View(tbListaPrecio);
        }

        // GET: /ListaPrecio/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbListaPrecio tbListaPrecio = db.tbListaPrecio.Find(id);
            if (tbListaPrecio == null)
            {
                return HttpNotFound();
            }
            ViewBag.listp_UsuarioCrea = new SelectList(db.tbUsuario, "usu_Id", "usu_NombreUsuario", tbListaPrecio.listp_UsuarioCrea);
            ViewBag.listp_UsuarioModifica = new SelectList(db.tbUsuario, "usu_Id", "usu_NombreUsuario", tbListaPrecio.listp_UsuarioModifica);
            ViewBag.listp_Id = new SelectList(db.tbListadoPrecioDetalle, "listp_Id", "prod_Codigo", tbListaPrecio.listp_Id);
            return View(tbListaPrecio);
        }

        // POST: /ListaPrecio/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="listp_Id,listp_EsActivo,listp_UsuarioCrea,listp_FechaCrea,listp_UsuarioModifica,listp_FechaModifica")] tbListaPrecio tbListaPrecio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbListaPrecio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.listp_UsuarioCrea = new SelectList(db.tbUsuario, "usu_Id", "usu_NombreUsuario", tbListaPrecio.listp_UsuarioCrea);
            ViewBag.listp_UsuarioModifica = new SelectList(db.tbUsuario, "usu_Id", "usu_NombreUsuario", tbListaPrecio.listp_UsuarioModifica);
            ViewBag.listp_Id = new SelectList(db.tbListadoPrecioDetalle, "listp_Id", "prod_Codigo", tbListaPrecio.listp_Id);
            return View(tbListaPrecio);
        }

        // GET: /ListaPrecio/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbListaPrecio tbListaPrecio = db.tbListaPrecio.Find(id);
            if (tbListaPrecio == null)
            {
                return HttpNotFound();
            }
            return View(tbListaPrecio);
        }

        // POST: /ListaPrecio/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbListaPrecio tbListaPrecio = db.tbListaPrecio.Find(id);
            db.tbListaPrecio.Remove(tbListaPrecio);
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
