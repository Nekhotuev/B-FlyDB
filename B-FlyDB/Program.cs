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
                BirthDate = new DateTime(1991, 06, 10),
                City = moscowCity,
                FirstName = "Vasiliy",
                LastName = "Petrov",
                Email = "smaple@mail.ru",
                PassportId = "4400 385264",
                PhoneNumber = "285-634-582-135",
                Title = "Mr",
                Zipcode = 143300,
                Login = "Petrov",
                Password = "PeSuHe137YY"
            };
            User u2 = new User()
            {
                Address = "1-ya Parkovaya, 12",
                BirthDate = new DateTime(1991, 06, 10),
                City = moscowCity,
                FirstName = "Vasiliy",
                LastName = "Petrov",
                Email = "smaple@mail.ru",
                PassportId = "4400 385264",
                PhoneNumber = "285-634-582-135",
                Title = "Mr",
                Zipcode = 143300,
                Login = "Petrov",
                Password = "PeSuHe137YY"
            };
            User u3 = new User()
            {
                Address = "1-ya Parkovaya, 12",
                BirthDate = new DateTime(1991, 06, 10),
                City = moscowCity,
                FirstName = "Vasiliy",
                LastName = "Petrov",
                Email = "smaple@mail.ru",
                PassportId = "4400 385264",
                PhoneNumber = "285-634-582-135",
                Title = "Mr",
                Zipcode = 143300,
                Login = "Petrov",
                Password = "PeSuHe137YY"
            };
            db.Users.Add(u2);
            db.SaveChanges();
        }
    }
}