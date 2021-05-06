using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BusStationWebApplication.Models
{
    public class Bus
    {
        public int BusID { get; set; }
        public int BusModelID { get; set; }
        public string Transporter { get; set; }
        public string NumberOfSeats { get; set; }
        [Display(Name = "Модель")]
        public virtual BusModel BusModel { get; set; }
    }
}
