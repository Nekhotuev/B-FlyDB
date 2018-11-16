using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Core.Model
{
    public class AirportViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public City City { get; set; }
        public ICollection<AirportScheme> AirportSchemes { get; set; }
    }
}