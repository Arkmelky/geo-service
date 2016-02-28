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
        [Key]
        public int AddressId { get; set; }

        [Display(Name = "Город")]
        [Required (ErrorMessage = "Введите название города")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Длина строки должна быть от 3 до 50 символов")]
        public string Country { get; set; }

        [Display(Name = "Область")]
        [Required (ErrorMessage = "Введите название области")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Длина строки должна быть от 3 до 50 символов")]
        public string Region { get; set; }

        [Display(Name = "Город")]
        [Required (ErrorMessage = "Введите название города")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Длина строки должна быть от 3 до 50 символов")]
        public string City { get; set; }

        [Display(Name = "Улица")]
        [Required(ErrorMessage = "Введите название улицы")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Длина строки должна быть от 3 до 50 символов")]
        public string Street { get; set; }

        [Display(Name = "Здание или Объект")]
        [Required(ErrorMessage = "Введите номер здания или название объекта")]
        public string Building { get; set; }

        public virtual List<GeoObject> GeoObjects { get; set; }

        public int id()
        {
            return AddressId;
        }

        public override string ToString()
        {
            return Country +" | "+ Region + " | " + City +" | "+Street+" | "+Building;
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