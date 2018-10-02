using System;
using System.Collections.Generic;

namespace B_FlyDB.Model
{
    public class Reservation
    {
        public Guid Id { get; set; }
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

        public ServiceClass ServiceClass { get; set; }
        public TimeTable TimeTable { get; set; }
        public User User { get; set; }
    }
}