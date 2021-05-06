using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BusStationWebApplication.Models
{
    public class Route
    {
        public int RouteID { get; set; }
        [Display(Name = "Місто відправлення")]
        public string ArrivalCity { get; set; }
        [Display(Name = "Місто прибуття")]
        public string DepartureCity { get; set; }
    }
}
