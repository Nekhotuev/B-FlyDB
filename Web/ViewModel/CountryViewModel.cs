using System.Collections.Generic;
using Core.Model;

namespace Web.ViewModel
{
    public class CountryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<City> Cities { get; set; }
    }
}