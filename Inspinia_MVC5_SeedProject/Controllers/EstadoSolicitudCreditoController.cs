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
    public class EstadoSolicitudCreditoController : Controller
    {
        private ERP_ZORZALEntities db = new ERP_ZORZALEntities();

        // GET: /EstadoSolicitudCredito/
        public ActionResult Index()
        {
            var tbestadosolicitudcredito = db.tbEstadoSolicitudCredito.Include(t => t.tbUsuario).Include(t => t.tbUsuario1);
            return View(tbestadosolicitudcredito.ToList());
        }

        // GET: /EstadoSolicitudCredito/Details/5
        public ActionResult Details(byte? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbEstadoSolicitudCredito tbEstadoSolicitudCredito = db.tbEstadoSolicitudCredito.Find(id);
            if (tbEstadoSolicitudCredito == null)
            {
                return HttpNotFound();
            }
            return View(tbEstadoSolicitudCredito);
        }

        // GET: /EstadoSolicitudCredito/Create
        public ActionResult Create()
        {
            ViewBag.escre_UsuarioCrea = new SelectList(db.tbUsuario, "usu_Id", "usu_NombreUsuario");
            ViewBag.escre_UsuarioModifica = new SelectList(db.tbUsuario, "usu_Id", "usu_NombreUsuario");
            return View();
        }

        // POST: /EstadoSolicitudCredito/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="escre_Id,escre_Descripcion,escre_UsuarioCrea,escre_UsuarioModifica,escre_FechaAgrego,escre_FechaModifica")] tbEstadoSolicitudCredito tbEstadoSolicitudCredito)
        {
            if (ModelState.IsValid)
            {
                db.tbEstadoSolicitudCredito.Add(tbEstadoSolicitudCredito);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.escre_UsuarioCrea = new SelectList(db.tbUsuario, "usu_Id", "usu_NombreUsuario", tbEstadoSolicitudCredito.escre_UsuarioCrea);
            ViewBag.escre_UsuarioModifica = new SelectList(db.tbUsuario, "usu_Id", "usu_NombreUsuario", tbEstadoSolicitudCredito.escre_UsuarioModifica);
            return View(tbEstadoSolicitudCredito);
        }

        // GET: /EstadoSolicitudCredito/Edit/5
        public ActionResult Edit(byte? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbEstadoSolicitudCredito tbEstadoSolicitudCredito = db.tbEstadoSolicitudCredito.Find(id);
            if (tbEstadoSolicitudCredito == null)
            {
                return HttpNotFound();
            }
            ViewBag.escre_UsuarioCrea = new SelectList(db.tbUsuario, "usu_Id", "usu_NombreUsuario", tbEstadoSolicitudCredito.escre_UsuarioCrea);
            ViewBag.escre_UsuarioModifica = new SelectList(db.tbUsuario, "usu_Id", "usu_NombreUsuario", tbEstadoSolicitudCredito.escre_UsuarioModifica);
            return View(tbEstadoSolicitudCredito);
        }

        // POST: /EstadoSolicitudCredito/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="escre_Id,escre_Descripcion,escre_UsuarioCrea,escre_UsuarioModifica,escre_FechaAgrego,escre_FechaModifica")] tbEstadoSolicitudCredito tbEstadoSolicitudCredito)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbEstadoSolicitudCredito).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.escre_UsuarioCrea = new SelectList(db.tbUsuario, "usu_Id", "usu_NombreUsuario", tbEstadoSolicitudCredito.escre_UsuarioCrea);
            ViewBag.escre_UsuarioModifica = new SelectList(db.tbUsuario, "usu_Id", "usu_NombreUsuario", tbEstadoSolicitudCredito.escre_UsuarioModifica);
            return View(tbEstadoSolicitudCredito);
        }

        // GET: /EstadoSolicitudCredito/Delete/5
        public ActionResult Delete(byte? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbEstadoSolicitudCredito tbEstadoSolicitudCredito = db.tbEstadoSolicitudCredito.Find(id);
            if (tbEstadoSolicitudCredito == null)
            {
                return HttpNotFound();
            }
            return View(tbEstadoSolicitudCredito);
        }

        // POST: /EstadoSolicitudCredito/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(byte id)
        {
            tbEstadoSolicitudCredito tbEstadoSolicitudCredito = db.tbEstadoSolicitudCredito.Find(id);
            db.tbEstadoSolicitudCredito.Remove(tbEstadoSolicitudCredito);
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
