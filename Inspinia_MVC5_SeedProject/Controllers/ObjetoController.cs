﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ERP_GMEDINA.Models;

namespace ERP_ZORZAL.Controllers
{
    public class ObjetoController : Controller
    {
        private ERP_ZORZALEntities db = new ERP_ZORZALEntities();

        // GET: /Objeto/
        public ActionResult Index()
        {
             return View(db.tbObjeto.ToList());
        }

        // GET: /Objeto/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbObjeto tbObjeto = db.tbObjeto.Find(id);
            if (tbObjeto == null)
            {
                return HttpNotFound();
            }
            return View(tbObjeto);
        }

        // GET: /Objeto/Create
        public ActionResult Create()
        {
            //ViewBag.obj_UsuarioCrea = new SelectList(db.tbUsuario, "usu_Id", "usu_NombreUsuario");
            //ViewBag.obj_UsuarioModifica = new SelectList(db.tbUsuario, "usu_Id", "usu_NombreUsuario");
            return View();
        }

        // POST: /Objeto/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include= "obj_Id,obj_Pantalla,obj_UsuarioCrea,obj_FechaCrea,obj_UsuarioModifica,obj_FechaModifica")] tbObjeto tbObjeto)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    IEnumerable<object> list = null;
                    var MsjError = "";
                    list = db.UDP_Acce_tbObjeto_Insert(tbObjeto.obj_Pantalla);
                    foreach (UDP_Inv_tbProductoCategoria_Insert_Result obejto in list)
                        MsjError = obejto.MensajeError;
                    if (MsjError == "-1")
                    {

                    }
                    else
                    {
                        return RedirectToAction("Index");
                    }

                }
                catch (Exception Ex)
                {
                    Ex.Message.ToString();
                    ModelState.AddModelError("", "No se Guardo el registro");
                }
                return RedirectToAction("Index");
            }
            return View(tbObjeto);
        }


        // GET: /Objeto/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbObjeto tbObjeto = db.tbObjeto.Find(id);
            if (tbObjeto == null)
            {
                return HttpNotFound();
            }
            ViewBag.obj_UsuarioCrea = new SelectList(db.tbUsuario, "usu_Id", "usu_NombreUsuario", tbObjeto.obj_UsuarioCrea);
            ViewBag.obj_UsuarioModifica = new SelectList(db.tbUsuario, "usu_Id", "usu_NombreUsuario", tbObjeto.obj_UsuarioModifica);
            return View(tbObjeto);
        }

        // POST: /Objeto/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit( int? id, [Bind(Include="obj_Id, obj_Pantalla,obj_UsuarioCrea,obj_FechaCrea,obj_UsuarioModifica,obj_FechaModifica")] tbObjeto tbObjeto)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    tbObjeto obj = db.tbObjeto.Find(id);
                    IEnumerable<object> list = null;
                    var MsjError = "";
                    list = db.UDP_Acce_tbObjeto_Update(tbObjeto.obj_Id,
                        tbObjeto.obj_Pantalla, obj.obj_UsuarioCrea,
                        obj.obj_FechaCrea);
                    foreach (UDP_Acce_tbObjeto_Update_Result obje in list)
                        MsjError = obje.MensajeError;

                    if (MsjError == "-1")
                    {
                        ModelState.AddModelError("", "No se guardo el registro");
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        return RedirectToAction("Index");
                    }
                }
                catch (Exception Ex)
                {
                    Ex.Message.ToString();
                    ModelState.AddModelError("", "No se Guardo el registro");
                }
                return RedirectToAction("Index");
            }
            return View(tbObjeto);

        }

        // GET: /Objeto/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbObjeto tbObjeto = db.tbObjeto.Find(id);
            if (tbObjeto == null)
            {
                return HttpNotFound();
            }
            return View(tbObjeto);
        }

        // POST: /Objeto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbObjeto tbObjeto = db.tbObjeto.Find(id);
            db.tbObjeto.Remove(tbObjeto);
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