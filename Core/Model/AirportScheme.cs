using System;
using System.Collections;
using System.Collections.Generic;

namespace Core.Model
{
    public class AirportScheme
    {
        public AirportScheme()
        {
            Arrivals = new List<Arrival>();
            Departures = new List<Departure>();
        }

        public Guid Id { get; set; }
        public Airport Airport { get; set; }
        public Terminal Terminal { get; set; }
        public Gate Gate { get; set; }
        public ICollection<Arrival> Arrivals { get; set; }
        public ICollection<Departure> Departures { get; set; }
    }
}