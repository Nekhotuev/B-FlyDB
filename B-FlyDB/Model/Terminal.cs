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
            Airports = new List<Airport>();
            Gates = new List<Gate>();
            Departures = new List<Departure>();
            Arrivals = new List<Arrival>();
        }
        
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Airport> Airports { get; set; }
        public ICollection<Gate> Gates { get; set; }
        public ICollection<Departure> Departures { get; set; }
        public ICollection<Arrival> Arrivals { get; set; }
    }
}

