using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BusStationWebApplication.Models
{
    public class Client
    {
        public int ClientID { get; set; }
        [Display(Name = "ПІБ")]
        public string FullName { get; set; }
        [Display(Name = "Телефон")]
        public string Telephone { get; set; }
    }
}
