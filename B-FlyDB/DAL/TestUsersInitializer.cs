using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using B_FlyDB.Model;

namespace B_FlyDB.DAL
{
    public class TestUsersInitializer : CreateDatabaseIfNotExists<UserContext>
    {
        protected override void Seed(UserContext db)
        {
            List<City> cities = db.Cities.ToList();

            if (cities.Count != 0)
            {
                User u1 = new User()
                {
                    Address = "1-ya Parkovaya, 12",
                    BirthDate = new DateTime(1964, 02, 18),
                    City = cities.First(c => c.Name == "Moscow"),
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
                    City = cities.First(c => c.Name == "Volgograd"),
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
                    City = cities.First(c => c.Name == "Berlin"),
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
                db.Users.AddRange(new List<User>() {u1, u2, u3});
            }

            db.SaveChanges();
        }
    }
}