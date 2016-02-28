using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Soloveyko_A_V_Geo_Service.Models;
using Soloveyko_A_V_Geo_Service.ViewModels;


namespace Soloveyko_A_V_Geo_Service.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Разработка гео-сервиса каталога компаний и общественных объектов РБ";

            var db = DataBase.GetDbContext();
            var context = new DataBaseRepository<GeoObject>(db);
            var listOfGeoObjects = context.GetAll();

            var listOfViewGeoObjects = new List<ViewGeoObj>();
            foreach (var geoObject in listOfGeoObjects)
            {
                if (geoObject.Location != null)
                {
                    listOfViewGeoObjects.Add(new ViewGeoObj(geoObject));

                }
            }

            ViewBag.listOfViewGeoObjects = listOfViewGeoObjects;

            return View();
        }
    }
}
