using System;
using System.Collections.Generic;

namespace Core.Model
{
    public class TimeTable
    {
        public int Id { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int FlightId { get; set; }
        public virtual Flight Flight { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; } 
    }
}