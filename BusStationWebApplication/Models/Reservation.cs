using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BusStationWebApplication.Models
{
    public class Reservation
    {
        public int ReservationID { get; set; }
        public int JourneyID { get; set; }
        [Display(Name = "Кількість квитків")]
        public string NumberOfTickets { get; set; }
        public int ClientID { get; set; }
        [Display(Name = "ФІО Клієнта")]
        public virtual Client Client { get; set; }
    }
}
