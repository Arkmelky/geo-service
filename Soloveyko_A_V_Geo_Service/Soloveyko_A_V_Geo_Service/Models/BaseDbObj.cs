using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Soloveyko_A_V_Geo_Service.Models
{
    //public class BaseDbObj
    //{
    //    public int Id { get; set; }
    //}

    public interface IBaseDbObj
    {
        int id();
    }
}