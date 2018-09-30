using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace B_FlyDB.Model
{
    public class Gate
    {
        public Gate()
        {
            AirportSchemes = new List<AirportScheme>();
            Departures = new List<Departure>();
            Arrivals = new List<Arrival>();
        }
        
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<AirportScheme> AirportSchemes { get; set; }
        public ICollection<Departure> Departures { get; set; }
        public ICollection<Arrival> Arrivals { get; set; }
    }
}