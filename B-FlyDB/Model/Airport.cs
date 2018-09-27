using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace B_FlyDB.Model
{
    public class Airport
    {
        public Airport()
        {
            Terminals = new List<Terminal>();
            Departures = new List<Departure>();
            Arrivals = new List<Arrival>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public Country Country { get; set; }
        public City City { get; set; }
        public ICollection<Terminal> Terminals { get; set; }
        public ICollection<Departure> Departures { get; set; }
        public ICollection<Arrival> Arrivals { get; set; }
    }
}