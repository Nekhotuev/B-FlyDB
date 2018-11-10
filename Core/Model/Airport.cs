using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Core.Model
{
    public class Airport
    {
        public Airport()
        {
            AirportSchemes = new List<AirportScheme>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public City City { get; set; }
        public ICollection<AirportScheme> AirportSchemes { get; set; }
    }
}