using System;
using System.Collections.Generic;

namespace B_FlyDB.Model
{
    public class Country
    {
        public Country()
        {
            Cities = new HashSet<City>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<City> Cities { get; set; }
    }
}