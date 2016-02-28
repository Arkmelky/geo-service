using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Soloveyko_A_V_Geo_Service.Models;

namespace Soloveyko_A_V_Geo_Service.Controllers
{
    public class GeoObjectController : Controller
    {
        private DataBase db = new DataBase();

        //
        // GET: /GeoObject/

        public ActionResult Index()
        {
            var geoobjects = db.GeoObjects.Include(g => g.Location).Include(g => g.Address).Include(g => g.GeoObjectType);
            return View(geoobjects.ToList());
        }

        //
        // GET: /GeoObject/Details/5

        public ActionResult Details(int id = 0)
        {
            GeoObject geoobject = db.GeoObjects.Find(id);
            if (geoobject == null)
            {
                return HttpNotFound();
            }
            return View(geoobject);
        }

        //
        // GET: /GeoObject/Create

        public ActionResult Create()
        {
            ViewBag.GeoObjectId = new SelectList(db.Locations, "GeoObjectId", "GeoObjectId");
            ViewBag.AddressId = db.Addresses.ToList();
            ViewBag.GeoObjectTypeId = new SelectList(db.GeoObjectTypes, "GeoObjectTypeId", "GeoObjectTypeName");
            return View();
        }

        //
        // POST: /GeoObject/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(GeoObject geoobject)
        {
            if (ModelState.IsValid)
            {
                db.GeoObjects.Add(geoobject);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.GeoObjectId = new SelectList(db.Locations, "GeoObjectId", "GeoObjectId", geoobject.GeoObjectId);
            ViewBag.AddressId = db.Addresses.ToList();
            ViewBag.GeoObjectTypeId = new SelectList(db.GeoObjectTypes, "GeoObjectTypeId", "GeoObjectTypeName", geoobject.GeoObjectTypeId);
            return View(geoobject);
        }

        //
        // GET: /GeoObject/Edit/5

        public ActionResult Edit(int id = 0)
        {
            GeoObject geoobject = db.GeoObjects.Find(id);
            if (geoobject == null)
            {
                return HttpNotFound();
            }
            ViewBag.GeoObjectId = new SelectList(db.Locations, "GeoObjectId", "GeoObjectId", geoobject.GeoObjectId);
            ViewBag.AddressId = db.Addresses.ToList();
            ViewBag.GeoObjectTypeId = new SelectList(db.GeoObjectTypes, "GeoObjectTypeId", "GeoObjectTypeName", geoobject.GeoObjectTypeId);
            ViewBag.Id = id;
            return View(geoobject);
        }

        //
        // POST: /GeoObject/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(GeoObject geoobject)
        {
            if (ModelState.IsValid)
            {
                db.Entry(geoobject).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.GeoObjectId = new SelectList(db.Locations, "GeoObjectId", "GeoObjectId", geoobject.GeoObjectId);
            ViewBag.AddressId = db.Addresses.ToList();
            ViewBag.GeoObjectTypeId = new SelectList(db.GeoObjectTypes, "GeoObjectTypeId", "GeoObjectTypeName", geoobject.GeoObjectTypeId);
            return View(geoobject);
        }

        //
        // GET: /GeoObject/Delete/5

        public ActionResult Delete(int id = 0)
        {
            GeoObject geoobject = db.GeoObjects.Find(id);
            if (geoobject == null)
            {
                return HttpNotFound();
            }
            return View(geoobject);
        }

        //
        // POST: /GeoObject/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GeoObject geoobject = db.GeoObjects.Find(id);
            db.GeoObjects.Remove(geoobject);
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