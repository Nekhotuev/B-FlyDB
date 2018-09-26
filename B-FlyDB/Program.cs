using System;
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
                
                Country c1 = new Country(){Name = "Russia"};
                db.Countries.Add(c1);
                City city1 = new City(){Name = "Moscow", Country = c1};
                db.Cities.Add(city1);
                db.SaveChanges();
                User u2 = new User(){Address = "1-ya Parkovaya, 12", BirthDate = new DateTime(1991, 06, 10), City = city1,
                    FirstName = "Vasiliy", LastName = "Petrov", Email = "smaple@mail.ru", PassportId = "4400 385264",
                    PhoneNumber = "285-634-582-135", Title = "Mr", Zipcode = 143300, Login = "deflog1", Password = "defPass1" };
                db.Users.Add(u2);
                db.SaveChanges();
                
                
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

        public DbSet<User> Users { get; set; }
        public DbSet<Airport> Airports { get; set; }
        public DbSet<Terminal> Terminals { get; set; }
        public DbSet<Gate> Gates { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        //public DbSet<Flight> Flights { get; set; }
        //public DbSet<TimeTable> FlightsTt { get; set; }
        //public DbSet<Plane> Planes { get; set; }
        //public DbSet<Seat> Seats { get; set; }
        //public DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AirportConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Conventions.Add(new IdConvention());
            modelBuilder.Conventions.Add(new NameConvention());
            //modelBuilder.Entity<User>().HasRequired(p => p.Profile).WithRequiredPrincipal(p => p.User);
        }
    }
}