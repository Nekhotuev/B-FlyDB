using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model
{
    public class Gate
    {
        public Gate()
        {
            AirportSchemes = new HashSet<AirportScheme>();
            Departures = new HashSet<Departure>();
            Arrivals = new HashSet<Arrival>();
        }
        
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<AirportScheme> AirportSchemes { get; set; }
        public ICollection<Departure> Departures { get; set; }
        public ICollection<Arrival> Arrivals { get; set; }
    }
}