using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using B_FlyDB;
using B_FlyDB.DAL;
using B_FlyDB.Model;

namespace B_FlyDB
{
    class Program
    {
        static void Main(string[] args)
        {
            

            using (ClassifiersContext context = new ClassifiersContext())
            {
                context.Airports.Select(a => a.Code == "SVO");
            }

            //using (BFlyContext db = new BFlyContext())
            //{
            //    db.Airports.Select(a => a.Code == "SVO");

            //}
        }
    }

    //TODO: make generic interface IRepository and generic class Repository which implements the interface where locate methods: Add(), Remove(), Get(Id), Find(predicate)
    public interface IRepository { }
    public class Repository { }
    //TODO: for each repository make interface which implements generic interface IRepository where locate new methods to work with DB
    public interface ICourseRepository{}
    //TODO: each repository should derives generic class and personal interface
    public class FlightRepository { }
    public class ReservationRepository { }
    public class TimeTableRepository { }
    public class UserRepository { }

    //TODO: make interface for unitofwork. It will contain properties with type of interface for all repositories and method Complete();
    public interface IUnitOfWork { }
    public class BuyTicketUoW { }
    public class CreateFlightUoW { }
    public class CreateTimeTableUoW { }
    public class CreateUserUoW { }

    public class BFlyContext : DbContext
    {
        public BFlyContext() : base("DefaultConnection")
        { }

        public DbSet<Airport> Airports { get; set; }
        public DbSet<AirportScheme> AirportSchemes { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Departure> Departures { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Gate> Gates { get; set; }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<ServiceClass> ServiceClasses { get; set; }
        public DbSet<Terminal> Terminals { get; set; }
        public DbSet<TimeTable> TimeTables { get; set; }
        public DbSet<User> Users { get; set; }

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

    public class TimeTableContest : DbContext { }
    public class ReservationContext : DbContext { }

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