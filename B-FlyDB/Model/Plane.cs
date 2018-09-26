using System;
using System.Collections.Generic;

namespace B_FlyDB.Model
{
    public class Plane
    {
        public Guid id { get; set; }
        public string PlaneModel { get; set; }
        public string PlaneModification { get; set; }
        public int FirstBCSeatRow { get; set; }
        public int LastBCSeatRow { get; set; }
        public char FirstBCSeat { get; set; }
        public char LastBCSeat { get; set; }
        public int FirstECSeatRow { get; set; }
        public int LastECSeatRow { get; set; }
        public char FirstECSeat { set; get; }
        public char LastECSeat { get; set; }
        public ICollection<Flight> Flights { get; set; }
    }
}