using System;
using System.Collections;
using System.Collections.Generic;

namespace Core.Model
{
    public class AirportScheme
    {
        public int Id { get; set; }
        public virtual Airport Airport { get; set; }
        public virtual Terminal Terminal { get; set; }
        public virtual Gate Gate { get; set; }
        public virtual ICollection<Flight> ArrivalFlights { get; set; }
        public virtual ICollection<Flight> DepartureFlights { get; set; }
    }
}