using System;
using System.Data.Entity.ModelConfiguration;

namespace B_FlyDB.Model
{
    public class FlightTimeTable
    {
        public Guid Id { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public Flight Flight { get; set; }
        public Plane Plane { get; set; }
    }
    public class FlightTimeTableConfiguration: EntityTypeConfiguration<FlightTimeTable>
    {
        public FlightTimeTableConfiguration()
        {
            Property(p => p.ArrivalTime).IsRequired();
            Property(p => p.DepartureTime).IsRequired();
        }
    }
}