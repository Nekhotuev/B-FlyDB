﻿using System.Data.Entity.ModelConfiguration;

namespace B_FlyDB.Model
{
    public class FlightConfiguration : EntityTypeConfiguration<Flight>
    {
        public FlightConfiguration()
        {
            Property(p => p.Code).IsRequired().HasMaxLength(10);
            Property(p => p.TicketPrice).IsRequired().HasPrecision(11, 2);
            Property(p => p.MaxDiscount).IsRequired();
            Property(p => p.SaleStartDay).IsRequired();
            Property(p => p.SaleEndDay).IsRequired();
            Property(p => p.DistanceInMile).IsRequired();
            Property(p => p.TimeOfFlight).IsRequired();
            Property(p => p.HandLuggageAmount).IsRequired();
            Property(p => p.HandLuggageMaxWeight).IsRequired();
            Property(p => p.LuggageAmount).IsRequired();
            Property(p => p.LuggageMaxWeight).IsRequired();
        }
    }
}