using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Core.Model
{
    public class Terminal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<AirportScheme> AirportSchemes { get; set; }
    }
}

