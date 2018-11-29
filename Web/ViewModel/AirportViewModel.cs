using System.Collections.Generic;
using Core.Model;

namespace Web.ViewModel
{
    public class AirportViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public virtual City City { get; set; }
        public virtual IEnumerable<AirportScheme> AirportSchemes { get; set; }
        public virtual IEnumerable<City> Cities { get; set; }
    }
}