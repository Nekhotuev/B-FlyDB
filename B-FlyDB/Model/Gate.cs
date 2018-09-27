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
            Terminals = new List<Terminal>();
            Departures = new List<Departure>();
            Arrivals = new List<Arrival>();
        }
        
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Terminal> Terminals { get; set; }
        public ICollection<Departure> Departures { get; set; }
        public ICollection<Arrival> Arrivals { get; set; }
    }
}