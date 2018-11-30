using System.Data.Entity;
using Core.Model;
using Core.Conventions;
using Data.Configurations;

namespace Data
{
    public class BflyContext : DbContext
    {
        public BflyContext() : base("DefaultConnection")
        { }

        public DbSet<Airport> Airports { get; set; }
        public DbSet<AirportScheme> AirportSchemes { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Gate> Gates { get; set; }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<ServiceClass> ServiceClasses { get; set; }
        public DbSet<Terminal> Terminals { get; set; }
        public DbSet<TimeTable> TimeTables { get; set; }
        public  DbSet<User> Users { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AirportConfiguration());
            modelBuilder.Configurations.Add(new AirportSchemeConfiguration());
            modelBuilder.Configurations.Add(new CityConfiguration());
            modelBuilder.Configurations.Add(new FlightConfiguration());
            modelBuilder.Configurations.Add(new PlaneConfiguration());
            modelBuilder.Configurations.Add(new ReservationConfiguration());
            modelBuilder.Configurations.Add(new TimeTableConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Conventions.Add(new IdConvention());
            modelBuilder.Conventions.Add(new NameConvention());
            modelBuilder.Entity<Flight>().HasOptional(p => p.ArrivalAirportScheme).WithMany(p => p.ArrivalFlights);
            modelBuilder.Entity<Flight>().HasOptional(p => p.DepartureAirportScheme).WithMany(p => p.DepartureFlights);

            base.OnModelCreating(modelBuilder);
        }
    }
}