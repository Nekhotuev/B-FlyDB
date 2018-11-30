using System.Data.Entity.ModelConfiguration;
using Core.Model;

namespace Data.Configurations
{
    public class TimeTableConfiguration: EntityTypeConfiguration<TimeTable>
    {
        public TimeTableConfiguration()
        {
            Property(p => p.ArrivalTime).IsRequired();
            Property(p => p.DepartureTime).IsRequired();
            Property(p => p.FlightId).IsOptional();
        }
    }
}