using System;
using System.Collections.Generic;

namespace B_FlyDB.Model
{
    public class Plane
    {
        public Plane()
        {
            Flights = new List<Flight>();
        }

        public Guid id { get; set; }
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
        public double FuelConsumptionOnOneMile { get; set; }
        public ICollection<Flight> Flights { get; set; }
    }
}