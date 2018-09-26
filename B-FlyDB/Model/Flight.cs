using System.Collections.Generic;

namespace B_FlyDB.Model
{
    public class Flight
    {
        public Flight()
        {
            TimeTables = new List<TimeTable>();
        }

        public ICollection<TimeTable> TimeTables { get; set; }
        public Plane Plane { get; set; }
        public Airport DepartureAirport { get; set; }
        public Terminal DepartureTerminal { get; set; }
        public Gate DepartureGate { get; set; }
        public Airport ArrivalAirport { get; set; }
        public Terminal ArrivalTerminal { get; set; }
        public Gate ArrivalGate { get; set; }

    }
}