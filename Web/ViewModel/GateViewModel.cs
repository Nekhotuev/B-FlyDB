using System.Collections.Generic;
using Core.Model;

namespace Web.ViewModel
{
    public class GateViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<AirportScheme> AirportSchemes { get; set; }
    }
}