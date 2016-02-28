using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Soloveyko_A_V_Geo_Service.Models;
using Soloveyko_A_V_Geo_Service.ViewModels;

namespace Soloveyko_A_V_Geo_Service.Controllers
{
    public class LocationController : Controller
    {
        private DataBase db = new DataBase();

        //
        // GET: /Location/

        public ActionResult Index()
        {
            var locations = db.Locations.Include(l => l.GeoObject);
            var locationsViewList = new List<LocationView>();
            foreach (var location in locations)
            {
                locationsViewList.Add(new LocationView(location));
            }
            return View(locationsViewList.ToList());
        }

        //
        // GET: /Location/Details/5

        public ActionResult Details(int id = 0)
        {
            Location location = db.Locations.Find(id);
            if (location == null)
            {
                return HttpNotFound();
            }
            return View(location);
        }

        //
        // GET: /Location/Create

        public ActionResult Create(int id =0)
        {
            Location location = db.Locations.Find(id);
            if (location == null)
            {
                var model = new Location();
                model.GeoObjectId = id;
                return View(model);
            }

            return RedirectToAction("Edit",new {id = id});
            
        }

        //
        // POST: /Location/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Location location)
        {
            if (ModelState.IsValid)
            {
                db.Locations.Add(location);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.GeoObjectId = new SelectList(db.GeoObjects, "GeoObjectId", "Name", location.GeoObjectId);
            return View(location);
        }

        //
        // GET: /Location/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Location location = db.Locations.Find(id);
            if (location == null)
            {
                return HttpNotFound();
            }
            ViewBag.GeoObjectId = new SelectList(db.GeoObjects, "GeoObjectId", "Name", location.GeoObjectId);
            return View(location);
        }

        //
        // POST: /Location/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Location location)
        {
            if (ModelState.IsValid)
            {
                db.Entry(location).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.GeoObjectId = new SelectList(db.GeoObjects, "GeoObjectId", "Name", location.GeoObjectId);
            return View(location);
        }

        //
        // GET: /Location/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Location location = db.Locations.Find(id);
            if (location == null)
            {
                return HttpNotFound();
            }
            return View(location);
        }

        //
        // POST: /Location/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Location location = db.Locations.Find(id);
            db.Locations.Remove(location);
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