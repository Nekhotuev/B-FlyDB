﻿using System;
using Core.Model;

namespace Web.ViewModel
{
    public class ReservationViewModel
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
        public virtual ServiceClass ServiceClass { get; set; }
        public virtual TimeTable TimeTable { get; set; }
        public virtual User User { get; set; }
    }
}