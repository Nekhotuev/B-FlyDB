using System;
using System.Collections.Generic;

namespace Core.Model
{
    public class TimeTableViewModel
    {
        public int Id { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public Flight Flight { get; set; }
        public ICollection<Reservation> Reservations { get; set; } 
    }
}