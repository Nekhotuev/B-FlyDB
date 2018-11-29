using System;
using System.Collections.Generic;
using Core.Model;

namespace Web.ViewModel
{
    public class TimeTableViewModel
    {
        public int Id { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public virtual Flight Flight { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; } 
    }
}