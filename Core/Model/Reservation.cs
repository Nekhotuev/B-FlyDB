using System;
using System.Collections.Generic;

namespace Core.Model
{
    public class Reservation
    {
        public int Id { get; set; }
        public bool Booked { get; set; }
        public int PreBookedSeatRow { get; set; }
        public string PreBookedSeatColumn { get; set; }
        public bool Paid { get; set; }
        public int RegisteredSeatRow { get; set; }
        public string RegisteredSeatColumn { get; set; }
        public int ExtraLuggageAmount { get; set; }
        public DateTime BookedDate { get; set; }
        public DateTime PaidDate { get; set; }
        public decimal FinalTicketPrice { get; set; }

        public int ServiceClassId { get; set; }
        public virtual ServiceClass ServiceClass { get; set; }
        public int TimeTableId { get; set; }
        public virtual TimeTable TimeTable { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}