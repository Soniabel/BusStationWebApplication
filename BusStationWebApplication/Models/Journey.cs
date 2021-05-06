using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusStationWebApplication.Models
{
    public class Journey
    {
        public int JourneyID { get; set; }
        public int RouteID { get; set; }
        public int BusID { get; set;}
        public decimal TicketPrice { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        
    }
}
