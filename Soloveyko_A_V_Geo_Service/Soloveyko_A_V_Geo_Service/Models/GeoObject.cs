using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Web;

namespace Soloveyko_A_V_Geo_Service.Models
{
    public class GeoObject : IBaseDbObj
    {
        [Key]
        public int GeoObjectId { get; set; }
        [Display(Name = "Название")]
        [Required(ErrorMessage = "Введите название Объекта")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Длина строки должна быть от 3 до 50 символов")]
        public string Name { get; set; }
        [Display(Name = "Описание")]
        [Required(ErrorMessage = "Введите название Объекта")]
        public string Description { get; set; }
        
        public virtual Location Location { get; set; }

        [Display(Name = "Адрес")]
        public int? AddressId { get; set; }
        public virtual Address Address { get; set; }

        [Display(Name = "Тип Объекта")]
        public int? GeoObjectTypeId { get; set; }
        public virtual GeoObjectType GeoObjectType { get; set; }

        public int id()
        {
            return GeoObjectId;
        }

        public override string ToString()
        {
            return Name;
        }
    }

    public class GeoObjectType
    {
        [Key]
        public int GeoObjectTypeId { get; set; }
        [Display(Name = "Тип Объекта")]
        [Required(ErrorMessage = "Введите название типа")]
        public string GeoObjectTypeName { get; set; }

        
        public List<GeoObject> GeoObjects { get; set; }
    }

    /*public enum EnumGeoObjectTypes
    {
        Park = 1,
        Cafe = 2,
        Restaurant = 3,
        Cinema = 4,
        Theater = 5,
        Opera = 6,
        Market = 7,
        Office = 8
    }*/
}