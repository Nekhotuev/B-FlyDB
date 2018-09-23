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
        }
        
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Airport> Airports { get; set; }
        public ICollection<Gate> Gates { get; set; }
    }
}

