using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Soloveyko_A_V_Geo_Service.Models
{
    public class Location : IBaseDbObj
    {
        [Key, ForeignKey("GeoObject")]
        public int GeoObjectId { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        
        public virtual GeoObject GeoObject { get; set; }

        public int id()
        {
            return GeoObjectId;
        }
    }
}