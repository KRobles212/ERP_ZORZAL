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
    public class SolicitudCreditoController : Controller
    {
        private ERP_ZORZALEntities db = new ERP_ZORZALEntities();

        // GET: /SolicitudCredito/
        public ActionResult Index()
        {
            var tbsolicitudcredito = db.tbSolicitudCredito.Include(t => t.tbUsuario).Include(t => t.tbUsuario1).Include(t => t.tbCliente).Include(t => t.tbEstadoSolicitudCredito);
            return View(tbsolicitudcredito.ToList());
        }

        // GET: /SolicitudCredito/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbSolicitudCredito tbSolicitudCredito = db.tbSolicitudCredito.Find(id);
            if (tbSolicitudCredito == null)
            {
                return HttpNotFound();
            }
            return View(tbSolicitudCredito);
        }

        // GET: /SolicitudCredito/Create
        public ActionResult Create()
        {
            ViewBag.cred_UsuarioCrea = new SelectList(db.tbUsuario, "usu_Id", "usu_NombreUsuario");
            ViewBag.cred_UsuarioModifica = new SelectList(db.tbUsuario, "usu_Id", "usu_NombreUsuario");
            ViewBag.clte_Id = new SelectList(db.tbCliente, "clte_Id", "clte_RTN_Identidad_Pasaporte");
            ViewBag.escre_Id = new SelectList(db.tbEstadoSolicitudCredito, "escre_Id", "escre_Descripcion");
            return View();
        }

        // POST: /SolicitudCredito/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="cred_Id,clte_Id,escre_Id,cred_FechaSolicitud,cred_FechaAprobacion,cred_MontoSolicitado,cred_MontoAprobado,cred_DiasSolicitado,cred_DiasAprobado,cred_UsuarioCrea,cred_FechaCrea,cred_UsuarioModifica,cred_FechaModifica")] tbSolicitudCredito tbSolicitudCredito)
        {
            if (ModelState.IsValid)
            {
                db.tbSolicitudCredito.Add(tbSolicitudCredito);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.cred_UsuarioCrea = new SelectList(db.tbUsuario, "usu_Id", "usu_NombreUsuario", tbSolicitudCredito.cred_UsuarioCrea);
            ViewBag.cred_UsuarioModifica = new SelectList(db.tbUsuario, "usu_Id", "usu_NombreUsuario", tbSolicitudCredito.cred_UsuarioModifica);
            ViewBag.clte_Id = new SelectList(db.tbCliente, "clte_Id", "clte_RTN_Identidad_Pasaporte", tbSolicitudCredito.clte_Id);
            ViewBag.escre_Id = new SelectList(db.tbEstadoSolicitudCredito, "escre_Id", "escre_Descripcion", tbSolicitudCredito.escre_Id);
            return View(tbSolicitudCredito);
        }

        // GET: /SolicitudCredito/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbSolicitudCredito tbSolicitudCredito = db.tbSolicitudCredito.Find(id);
            if (tbSolicitudCredito == null)
            {
                return HttpNotFound();
            }
            ViewBag.cred_UsuarioCrea = new SelectList(db.tbUsuario, "usu_Id", "usu_NombreUsuario", tbSolicitudCredito.cred_UsuarioCrea);
            ViewBag.cred_UsuarioModifica = new SelectList(db.tbUsuario, "usu_Id", "usu_NombreUsuario", tbSolicitudCredito.cred_UsuarioModifica);
            ViewBag.clte_Id = new SelectList(db.tbCliente, "clte_Id", "clte_RTN_Identidad_Pasaporte", tbSolicitudCredito.clte_Id);
            ViewBag.escre_Id = new SelectList(db.tbEstadoSolicitudCredito, "escre_Id", "escre_Descripcion", tbSolicitudCredito.escre_Id);
            return View(tbSolicitudCredito);
        }

        // POST: /SolicitudCredito/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="cred_Id,clte_Id,escre_Id,cred_FechaSolicitud,cred_FechaAprobacion,cred_MontoSolicitado,cred_MontoAprobado,cred_DiasSolicitado,cred_DiasAprobado,cred_UsuarioCrea,cred_FechaCrea,cred_UsuarioModifica,cred_FechaModifica")] tbSolicitudCredito tbSolicitudCredito)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbSolicitudCredito).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.cred_UsuarioCrea = new SelectList(db.tbUsuario, "usu_Id", "usu_NombreUsuario", tbSolicitudCredito.cred_UsuarioCrea);
            ViewBag.cred_UsuarioModifica = new SelectList(db.tbUsuario, "usu_Id", "usu_NombreUsuario", tbSolicitudCredito.cred_UsuarioModifica);
            ViewBag.clte_Id = new SelectList(db.tbCliente, "clte_Id", "clte_RTN_Identidad_Pasaporte", tbSolicitudCredito.clte_Id);
            ViewBag.escre_Id = new SelectList(db.tbEstadoSolicitudCredito, "escre_Id", "escre_Descripcion", tbSolicitudCredito.escre_Id);
            return View(tbSolicitudCredito);
        }

        // GET: /SolicitudCredito/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbSolicitudCredito tbSolicitudCredito = db.tbSolicitudCredito.Find(id);
            if (tbSolicitudCredito == null)
            {
                return HttpNotFound();
            }
            return View(tbSolicitudCredito);
        }

        // POST: /SolicitudCredito/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbSolicitudCredito tbSolicitudCredito = db.tbSolicitudCredito.Find(id);
            db.tbSolicitudCredito.Remove(tbSolicitudCredito);
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
