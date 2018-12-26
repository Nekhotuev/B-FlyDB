using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Model;

namespace Web.ViewModel
{
    public class UserViewModel
    {
        public int Id { get; set; }

        [StringLength(20, MinimumLength = 3, ErrorMessage = "Length st be between 3 and 20")]
        [RegularExpression(@"[A-Za-z0-9]", ErrorMessage = "Login must contain chars and numbers")]
        public string Login { get; set; }

        [DataType(DataType.Password)]
        [StringLength(60, MinimumLength = 8, ErrorMessage = "Length must be between 8 and 50 chars")]
        public string Password { get; set; }

        [StringLength(20, MinimumLength = 3, ErrorMessage = "Length st be between 3 and 20")]
        [RegularExpression(@"[A-Za-z]", ErrorMessage = "Must contain only chars")]
        public string FirstName { get; set; }

        [StringLength(20, MinimumLength = 3, ErrorMessage = "Length st be between 3 and 20")]
        [RegularExpression(@"[A-Za-z]", ErrorMessage = "Must contain only chars")]
        public string LastName { get; set; }

        [RegularExpression(@"[Mr]|[Ms]|[Mrs]", ErrorMessage = "Title must be Mr or Ms or Mrs")]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        [RegularExpression(@"(0[1-9]|1[012])+\.(0[1-9]|[12][0-9]|3[01])+\.(19|20)\\d\\d$")]
        public DateTime BirthDate { get; set; }

        [StringLength(12, MinimumLength = 6, ErrorMessage = "Length must be between 6 and 12 chars")]
        [RegularExpression(@"[A-Za-z0-9]", ErrorMessage = "Format is incorrect")]
        public string PassportId { get; set; }

        [DataType(DataType.PhoneNumber)]
        [StringLength(15, MinimumLength = 6, ErrorMessage = "Phone number length is invalid")]
        public string PhoneNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "E-mail format is incorrect")]
        public string Email { get; set; }

        [DataType(DataType.PostalCode)]
        [StringLength(12, MinimumLength = 3, ErrorMessage = "Zipcode must be between 3 and 12 chars")]
        [RegularExpression(@"[A-Za-z0-9]", ErrorMessage = "Format is incorrect")]
        public int Zipcode { get; set; }

        public int CityId { get; set; }
        public virtual City City { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}