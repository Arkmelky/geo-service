using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Soloveyko_A_V_Geo_Service.Models
{
    public class Address : IBaseDbObj
    {
        public int AddressId { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Building { get; set; }

        public virtual List<GeoObject> GeoObjects { get; set; }

        public int id()
        {
            return AddressId;
        }
    }
    /*public class Country : IBaseDbObj
    {
        public int CountryId { get; set; }
        public string Name { get; set; }
        
        public virtual List<Region> Regions { get; set; }

        public int id()
        {
            return CountryId;
        }
    }

    public class Region : IBaseDbObj
    {
        public int RegionId { get; set; }
        public string Name { get; set; }
        
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }

        public virtual List<City> Cities { get; set; }
        public int id()
        {
            return RegionId;
        }

    }

    public class City : IBaseDbObj
    {
        public int CityId { get; set; }
        public string Name { get; set; }
        
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }

        
        public int RegionId { get; set; }
        public virtual Region Region { get; set; }

        public virtual List<Street> Streets { get; set; }
        public int id()
        {
            return CityId;
        }

    }

    public class Street : IBaseDbObj
    {
        public int StreetId { get; set; }
        public string Name { get; set; }
        
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }

        
        public int RegionId { get; set; }
        public virtual Region Region { get; set; }

 
        public int CityId { get; set; }
        public virtual City City { get; set; }

        public virtual List<Building> Buildings { get; set; }
        public int id()
        {
            return StreetId;
        }
    }

    public class Building : IBaseDbObj
    {
        [Key]
        public int BuildingId { get; set; }
        public string Name { get; set; }
        
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }

        
        public int RegionId { get; set; }
        public virtual Region Region { get; set; }

        
        public int CityId { get; set; }
        public virtual City City { get; set; }

        
        public int StreetId { get; set; }
        public virtual Street Street { get; set; }

        public int id()
        {
            return BuildingId;
        }
    }*/

    
}