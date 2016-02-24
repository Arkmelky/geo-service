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

            //var db = DataBase.GetDbContext();
            //db.SaveChanges();
            var repo = new DataBaseRepository<Address>(DataBase.GetDbContext());
            var newAddress = new Address();
            newAddress.Country = "Belarus";
            newAddress.Region = "Minsk";
            newAddress.City = "Minsk";
            newAddress.Street = "Pl. Lenina";
            newAddress.Building = "12/4";

            repo.Add(newAddress);

            ViewBag.address = newAddress;
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
