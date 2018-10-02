using System.Data.Entity;
using B_FlyDB.Model;

namespace B_FlyDB.DAL
{
    public class FlightsContext : DbContext
    {
        public FlightsContext() : base("DefaultConnection")
        { }

        public DbSet<Airport> Airports { get; set; }
        public DbSet<AirportScheme> AirportSchemes { get; set; }
        public DbSet<Departure> Departures { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Gate> Gates { get; set; }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Terminal> Terminals { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AirportConfiguration());
            modelBuilder.Configurations.Add(new FlightConfiguration());
            modelBuilder.Configurations.Add(new PlaneConfiguration());
            modelBuilder.Configurations.Add(new ReservationConfiguration());
            modelBuilder.Configurations.Add(new TimeTableConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Conventions.Add(new IdConvention());
            modelBuilder.Conventions.Add(new NameConvention());
        }
    }
}