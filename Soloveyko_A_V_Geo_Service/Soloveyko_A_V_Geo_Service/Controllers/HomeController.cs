using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Soloveyko_A_V_Geo_Service.Models;

namespace Soloveyko_A_V_Geo_Service.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            using (var db = new DataBase())
            {
                var address = new Address();
                address.Country = "Belarus";
                address.City = "Minsk";
                address.Street = "Gashkevicha";
                address.Building = "6/74";
                db.Addresses.Add(address);
                db.SaveChanges();
            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
