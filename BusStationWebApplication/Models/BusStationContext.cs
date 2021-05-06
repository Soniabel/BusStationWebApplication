using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;

namespace BusStationWebApplication.Models
{
    public class BusStationContext: DbContext
    {
        public virtual DbSet<Bus> Buses { get; set; }
        public virtual DbSet<BusModel> BusModels { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Journey> Journeys { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Route> Routes { get; set; }

        public BusStationContext(DbContextOptions<BusStationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

    }
}
