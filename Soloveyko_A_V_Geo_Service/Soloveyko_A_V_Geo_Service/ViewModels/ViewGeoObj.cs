using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Soloveyko_A_V_Geo_Service.Models;

namespace Soloveyko_A_V_Geo_Service.ViewModels
{
    public class ViewGeoObj
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public string FullAddress { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public ViewGeoObj( GeoObject geoObject)
        {
            this.Name = geoObject.Name;
            this.Description = geoObject.Description;
            this.FullAddress = geoObject.Address.ToString();
            this.Latitude = geoObject.Location.Latitude;
            this.Longitude = geoObject.Location.Longitude;
        }
    }
}