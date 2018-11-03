﻿using System.Data.Entity.ModelConfiguration;

namespace Core.Configuration
{
    public class TimeTableConfiguration: EntityTypeConfiguration<TimeTable>
    {
        public TimeTableConfiguration()
        {
            Property(p => p.ArrivalTime).IsRequired();
            Property(p => p.DepartureTime).IsRequired();
        }
    }
}