using System;
using System.ComponentModel.DataAnnotations;
using Core.Model;

namespace Web.ViewModel
{
    public class ReservationViewModel
    {
        public int Id { get; set; }

        public bool Booked { get; set; }

        [Required]
        [Range(0, 200, ErrorMessage = "Range must be between 0 and 200")]
        public int PreBookedSeatRow { get; set; }

        [Required]
        [RegularExpression(@"[A-Za-z]", ErrorMessage = "Must contain only chars")]
        public string PreBookedSeatColumn { get; set; }

        public bool Paid { get; set; }

        [Range(0, 200, ErrorMessage = "Range must be between 0 and 200")]
        public int RegisteredSeatRow { get; set; }

        [RegularExpression(@"[A-Za-z]", ErrorMessage = "Must contain only chars")]
        public string RegisteredSeatColumn { get; set; }

        [Required]
        [Range(0, 10, ErrorMessage = "Range must be between 0 and 10")]
        public int ExtraLuggageAmount { get; set; }

        [DataType(DataType.Date)]
        [Required]
        [RegularExpression(@"\d{4}-\d{2}-\d{2}", ErrorMessage = "Format must be yyyy-mm-dd")]
        public DateTime BookedDate { get; set; }

        [DataType(DataType.Date)]
        [RegularExpression(@"\d{4}-\d{2}-\d{2}", ErrorMessage = "Format must be yyyy-mm-dd")]
        public DateTime PaidDate { get; set; }

        [DataType(DataType.Currency)]
        [Required]
        [Range(0, 100000, ErrorMessage = "Must be between 0 and 100000")]
        public decimal FinalTicketPrice { get; set; }

        public int ServiceClassId { get; set; }
        public virtual ServiceClass ServiceClass { get; set; }
        public int TimeTableId { get; set; }
        public virtual TimeTable TimeTable { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}