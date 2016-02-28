using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Soloveyko_A_V_Geo_Service.Models;

namespace Soloveyko_A_V_Geo_Service.ViewModels
{
    public class LocationView
    {
        public int GeoObjectId { get; set; }
        [Display(Name = "Широта")]
        public double Latitude { get; set; }
        [Display(Name = "Долгота")]
        public double Longitude { get; set; }
        [Display(Name = "Объект")]
        public string GeoObjectName { get; set; }

        public LocationView(Location location)
        {
            this.GeoObjectId = location.GeoObjectId;
            this.Latitude = location.Latitude;
            this.Longitude = location.Longitude;
            this.GeoObjectName = location.GeoObject.ToString();
        }
    }
}