using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MusicStore.Models;

namespace MusicStore.Controllers
{
    public class FaixasController : Controller
    {
        private DbFaixa db = new DbFaixa();

        // GET: Faixas
        public ActionResult Index()
        {
            return View(db.Faixas.ToList());
        }

        // GET: Faixas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Faixa faixa = db.Faixas.Find(id);
            if (faixa == null)
            {
                return HttpNotFound();
            }
            return View(faixa);
        }

        // GET: Faixas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Faixas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "_faixaID,TituloFaixa,NomeFeat")] Faixa faixa)
        {
            if (ModelState.IsValid)
            {
                db.Faixas.Add(faixa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(faixa);
        }

        // GET: Faixas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Faixa faixa = db.Faixas.Find(id);
            if (faixa == null)
            {
                return HttpNotFound();
            }
            return View(faixa);
        }

        // POST: Faixas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "_faixaID,TituloFaixa,NomeFeat")] Faixa faixa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(faixa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(faixa);
        }

        // GET: Faixas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Faixa faixa = db.Faixas.Find(id);
            if (faixa == null)
            {
                return HttpNotFound();
            }
            return View(faixa);
        }

        // POST: Faixas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Faixa faixa = db.Faixas.Find(id);
            db.Faixas.Remove(faixa);
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
