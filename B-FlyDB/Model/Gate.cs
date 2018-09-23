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
        }
        
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Terminal> Terminals { get; set; }
    }
}