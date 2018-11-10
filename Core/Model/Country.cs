using System;
using System.Collections.Generic;

namespace Core.Model
{
    public class Country
    {
        public Country()
        {
            Cities = new List<City>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<City> Cities { get; set; }
    }
}