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
            Flights = new List<Flight>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public Country Country { get; set; }
        public City City { get; set; }
        public ICollection<Terminal> Terminals { get; set; }
        public ICollection<Flight> Flights { get; set; }
    }
}