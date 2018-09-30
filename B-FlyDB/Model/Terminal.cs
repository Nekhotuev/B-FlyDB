using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace B_FlyDB.Model
{
    public class Terminal
    {
        public Terminal()
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

