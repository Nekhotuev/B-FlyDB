using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Core.Model
{
    public class Airport
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public virtual City City { get; set; }
        public virtual ICollection<AirportScheme> AirportSchemes { get; set; }
    }
}