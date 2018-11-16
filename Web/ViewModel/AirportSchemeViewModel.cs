using System;
using System.Collections;
using System.Collections.Generic;

namespace Core.Model
{
    public class AirportSchemeViewModel
    {
        public int Id { get; set; }
        public Airport Airport { get; set; }
        public Terminal Terminal { get; set; }
        public Gate Gate { get; set; }
        public ICollection<Flight> ArrivalFlights { get; set; }
        public ICollection<Flight> DepartureFlights { get; set; }
    }
}