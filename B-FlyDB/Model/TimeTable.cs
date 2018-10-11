using System;
using System.Collections.Generic;

namespace B_FlyDB.Model
{
    public class TimeTable
    {
        public TimeTable()
        {
            Reservations = new HashSet<Reservation>();
        }

        public Guid Id { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public Flight Flight { get; set; }
        public ICollection<Reservation> Reservations { get; set; } 
    }
}