using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace B_FlyDB.Model
{
    public class User
    {
        public User()
        {
            Reservations = new HashSet<Reservation>();
        }

        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime BirthDate { get; set; }
        public string PassportId { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int Zipcode { get; set; }
        public City City { get; set; }
        public string Address { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}