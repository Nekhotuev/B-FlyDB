using System.Collections.Generic;
using Core.Model;

namespace Web.ViewModel
{
    public class PlaneViewModel
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string PlaneModel { get; set; }
        public string PlaneModification { get; set; }
        public int FirstBCSeatRow { get; set; }
        public int LastBCSeatRow { get; set; }
        public string FirstBCSeat { get; set; }
        public string LastBCSeat { get; set; }
        public int FirstECSeatRow { get; set; }
        public int LastECSeatRow { get; set; }
        public string FirstECSeat { set; get; }
        public string LastECSeat { get; set; }
        public double FuelConsumptionPerKm { get; set; }

        public virtual ICollection<Flight> Flights { get; set; }
    }
}