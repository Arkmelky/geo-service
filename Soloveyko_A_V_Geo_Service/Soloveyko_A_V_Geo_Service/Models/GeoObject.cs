using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Soloveyko_A_V_Geo_Service.Models
{
    public class GeoObject : IBaseDbObj
    {
        public int GeoObjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int GeoObjectType { get; set; }
        
        public virtual Location Location { get; set; }

        public int? AddressId { get; set; }
        public virtual Address Address { get; set; }

        public int id()
        {
            return GeoObjectId;
        }
    }

    public enum EnumGeoObjectTypes
    {
        Park = 1,
        Cafe = 2,
        Restaurant = 3,
        Cinema = 4,
        Theater = 5,
        Opera = 6,
        Market = 7,
        Office = 8
    }
}