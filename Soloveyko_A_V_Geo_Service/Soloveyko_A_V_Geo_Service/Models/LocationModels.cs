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
        [Display(Name = "Широта")]
        [Required(ErrorMessage = "Введите Широту")]
        public double Latitude { get; set; }
        [Display(Name = "Долгота")]
        [Required(ErrorMessage = "Введите Долготу")]
        public double Longitude { get; set; }
        
        public virtual GeoObject GeoObject { get; set; }

        public Location()
        {
            Latitude = 0;
            Longitude = 0;
        }

        public int id()
        {
            return GeoObjectId;
        }
    }
}