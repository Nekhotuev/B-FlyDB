using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B_FlyDB;
using B_FlyDB.Model;

namespace B_FlyDB
{
    class Program
    {
        static void Main(string[] args)
        {
            using (BFlyContext db = new BFlyContext())
            {
                
                
            }
        }
    }

    //TODO: make generic interface IRepository and generic class Repository which implements the interface where locate methods: Add(), Remove(), Get(Id), Find(predicate)
    public interface IRepository { }
    public class Repository { }
    //TODO: for each repository make interface which implements generic interface IRepository where locate new methods to work with DB
    public interface ICourseRepository{}
    //TODO: each repository should derives generic class and personal interface
    public class CourseRepository { }

    //TODO: make interface for unitofwork. It will contain properties with type of interface for all repositories and method Complete();
    public interface IUnitOfWork { }
    public class UnitOfWork { }

    public class BFlyContext : DbContext
    {
        public BFlyContext() : base("DefaultConnection")
        { }

        static BFlyContext()
        {
            System.Data.Entity.Database.SetInitializer<BFlyContext>(new DbInitializer());
        }

        
        public DbSet<Airport> Airports { get; set; }
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

    public class ClassifiersInitializer : DropCreateDatabaseIfModelChanges<BFlyContext>
    {
        protected override void Seed(BFlyContext context)
        {
            Airport domodedovoAirport = new Airport();
            Airport vnukovoAirport = new Airport();
            Airport scheremetevoAirport = new Airport();
            Airport volgAirport = new Airport();
            Airport saratovAirport = new Airport();
            Airport sochiAirport = new Airport();
            Airport schipholAirport = new Airport();
            Airport sharlDeGollAirport = new Airport();
            Airport schonefieldAirport = new Airport();
            Airport frankfurtOnMaineAirport = new Airport();
            Airport letischeVarnAirport = new Airport();

            Terminal aTerminal = new Terminal();
            Terminal bTerminal = new Terminal();
            Terminal cTerminal = new Terminal();
            Terminal dTerminal = new Terminal();
            Terminal eTerminal = new Terminal();

            Gate gate1 = new Gate();
            Gate gate2 = new Gate();
            Gate gate3 = new Gate();
            Gate gate4 = new Gate();
            Gate gate5 = new Gate();
            Gate gate6 = new Gate();
            Gate gate7 = new Gate();
            Gate gate8 = new Gate();
            Gate gate9 = new Gate();
            Gate gate10 = new Gate();
            Gate gate11 = new Gate();
            Gate gate12 = new Gate();
            Gate gate13 = new Gate();
            Gate gate14 = new Gate();
            Gate gate15 = new Gate() {};
            
            
        }
    }

    public class DbInitializer : DropCreateDatabaseIfModelChanges<BFlyContext>
    {
        protected override void Seed(BFlyContext db)
        {
            Country russiaCountry = new Country() { Name = "Russia" };
            Country franceCountry = new Country() { Name = "France"};
            Country netherlandsCountry = new Country() { Name = "Netherlands"};
            Country germanyCountry = new Country() { Name = "Germany"};
            Country bulgariaCountry = new Country() { Name = "Bulgaria"};
            db.Countries.AddRange(new List<Country>(){russiaCountry, franceCountry, netherlandsCountry, germanyCountry, bulgariaCountry});
            City moscowCity = new City() { Name = "Moscow", Country = russiaCountry };
            City volgogradCity = new City() { Name = "Volgograd", Country = russiaCountry};
            City saratovCity = new City() { Name = "Saratov", Country = russiaCountry};
            City sochiCity = new City() { Name = "Sochi", Country = russiaCountry};
            City amsterdamCity = new City() { Name = "Amsterdam", Country = netherlandsCountry};
            City parisCity = new City() { Name = "Paris", Country = franceCountry};
            City berlinCity = new City() { Name = "Berlin", Country = germanyCountry};
            City frankfurtCity = new City() { Name = "Frankfurt", Country = germanyCountry};
            City varnaCity = new City() { Name = "Varna", Country = bulgariaCountry};
            db.Cities.AddRange(new List<City>() {moscowCity, volgogradCity, saratovCity, sochiCity, amsterdamCity, parisCity, berlinCity, frankfurtCity, varnaCity});
            db.SaveChanges();
            User u1 = new User()
            {
                Address = "1-ya Parkovaya, 12",
                BirthDate = new DateTime(1964, 02, 18),
                City = moscowCity,
                FirstName = "Vasiliy",
                LastName = "Petrov",
                Email = "petrov@mail.ru",
                PassportId = "4400 385264",
                PhoneNumber = "985-654-78-96",
                Title = "Mr",
                Zipcode = 143300,
                Login = "Petrov",
                Password = "PeSuHe137YY"
            };
            User u2 = new User()
            {
                Address = "Profsoyuznaya, 2",
                BirthDate = new DateTime(1985, 09, 13),
                City = volgogradCity,
                FirstName = "Ivan",
                LastName = "Nikolaev",
                Email = "nikolaev@mail.ru",
                PassportId = "4400 159753",
                PhoneNumber = "915-123-45-69",
                Title = "Mr",
                Zipcode = 143200,
                Login = "Nikola",
                Password = "KvasReal77"
            };
            User u3 = new User()
            {
                Address = "Atlassian, 84",
                BirthDate = new DateTime(1976, 05, 28),
                City = berlinCity,
                FirstName = "Jack",
                LastName = "Anderson",
                Email = "anderson@gmail.com",
                PassportId = "415 8965741",
                PhoneNumber = "285-634-582-135",
                Title = "Mr",
                Zipcode = 569208,
                Login = "Anderson",
                Password = "AAAA6793"
            };
            db.Users.AddRange(new List<User>() { u1, u2, u3 });
            db.SaveChanges();
        }
    }
}