using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Core.Model
{
    public class Airport
    {
        public Airport()
        {
            AirportSchemes = new HashSet<AirportScheme>();
            Departures = new HashSet<Departure>();
            Arrivals = new HashSet<Arrival>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public Country Country { get; set; }
        public City City { get; set; }
        public ICollection<AirportScheme> AirportSchemes { get; set; }
        public ICollection<Departure> Departures { get; set; }
        public ICollection<Arrival> Arrivals { get; set; }
    }
}