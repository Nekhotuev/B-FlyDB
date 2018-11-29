using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model
{
    public class Gate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<AirportScheme> AirportSchemes { get; set; }
    }
}