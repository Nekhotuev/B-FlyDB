using System;
using System.Collections.Generic;

namespace Core.Model
{
    public class CountryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<City> Cities { get; set; }
    }
}