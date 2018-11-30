using System;
using System.Collections.Generic;
using Core.Model;

namespace Web.ViewModel
{
    public class UserViewModel
    {
        public int Id { get; set; }
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
        public int CityId { get; set; }
        public virtual City City { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}