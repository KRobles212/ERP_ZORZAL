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
    public class TipoPagoController : Controller
    {
        private ERP_ZORZALEntities db = new ERP_ZORZALEntities();

        // GET: /TipoPago/
        public ActionResult Index()
        {
            var tbtipopago = db.tbTipoPago.Include(t => t.tbUsuario).Include(t => t.tbUsuario1);
            return View(tbtipopago.ToList());
        }

        // GET: /TipoPago/Details/5
        public ActionResult Details(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbTipoPago tbTipoPago = db.tbTipoPago.Find(id);
            if (tbTipoPago == null)
            {
                return HttpNotFound();
            }
            return View(tbTipoPago);
        }

        // GET: /TipoPago/Create
        public ActionResult Create()
        {
            ViewBag.tpa_UsuarioCrea = new SelectList(db.tbUsuario, "usu_Id", "usu_NombreUsuario");
            ViewBag.tpa_UsuarioModifica = new SelectList(db.tbUsuario, "usu_Id", "usu_NombreUsuario");
            return View();
        }

        // POST: /TipoPago/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="tpa_Id,tpa_Descripcion,tpa_Emisor,tpa_Cuenta,tpa_FechaVencimiento,tpa_Titular,tpa_UsuarioCrea,tpa_FechaCrea,tpa_UsuarioModifica,tpa_FechaModifica")] tbTipoPago tbTipoPago)
        {
            if (ModelState.IsValid)
            {
                db.tbTipoPago.Add(tbTipoPago);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.tpa_UsuarioCrea = new SelectList(db.tbUsuario, "usu_Id", "usu_NombreUsuario", tbTipoPago.tpa_UsuarioCrea);
            ViewBag.tpa_UsuarioModifica = new SelectList(db.tbUsuario, "usu_Id", "usu_NombreUsuario", tbTipoPago.tpa_UsuarioModifica);
            return View(tbTipoPago);
        }

        // GET: /TipoPago/Edit/5
        public ActionResult Edit(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbTipoPago tbTipoPago = db.tbTipoPago.Find(id);
            if (tbTipoPago == null)
            {
                return HttpNotFound();
            }
            ViewBag.tpa_UsuarioCrea = new SelectList(db.tbUsuario, "usu_Id", "usu_NombreUsuario", tbTipoPago.tpa_UsuarioCrea);
            ViewBag.tpa_UsuarioModifica = new SelectList(db.tbUsuario, "usu_Id", "usu_NombreUsuario", tbTipoPago.tpa_UsuarioModifica);
            return View(tbTipoPago);
        }

        // POST: /TipoPago/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="tpa_Id,tpa_Descripcion,tpa_Emisor,tpa_Cuenta,tpa_FechaVencimiento,tpa_Titular,tpa_UsuarioCrea,tpa_FechaCrea,tpa_UsuarioModifica,tpa_FechaModifica")] tbTipoPago tbTipoPago)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbTipoPago).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.tpa_UsuarioCrea = new SelectList(db.tbUsuario, "usu_Id", "usu_NombreUsuario", tbTipoPago.tpa_UsuarioCrea);
            ViewBag.tpa_UsuarioModifica = new SelectList(db.tbUsuario, "usu_Id", "usu_NombreUsuario", tbTipoPago.tpa_UsuarioModifica);
            return View(tbTipoPago);
        }

        // GET: /TipoPago/Delete/5
        public ActionResult Delete(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbTipoPago tbTipoPago = db.tbTipoPago.Find(id);
            if (tbTipoPago == null)
            {
                return HttpNotFound();
            }
            return View(tbTipoPago);
        }

        // POST: /TipoPago/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(short id)
        {
            tbTipoPago tbTipoPago = db.tbTipoPago.Find(id);
            db.tbTipoPago.Remove(tbTipoPago);
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