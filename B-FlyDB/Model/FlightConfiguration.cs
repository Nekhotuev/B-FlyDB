using System.Data.Entity.ModelConfiguration;

namespace B_FlyDB.Model
{
    public class FlightConfiguration : EntityTypeConfiguration<Flight>
    {
        public FlightConfiguration()
        {
            Property(p => p.Code).IsRequired().HasMaxLength(10);
            Property(p => p.TicketPrice).IsRequired();
            Property(p => p.MaxDiscount).IsRequired();
            Property(p => p.SaleStartDay).IsRequired();
            Property(p => p.SaleEndDay).IsRequired();
            Property(p => p.DistanceInMile).IsRequired();
            Property(p => p.TimeOfFlight).IsRequired();
            Property(p => p.HandLuggageAmount).IsRequired();
            Property(p => p.HandLuggageMaxWeight).IsRequired();
            Property(p => p.LuggageAmount).IsRequired();
            Property(p => p.LuggageMaxWeight).IsRequired();
            //HasRequired(p => p.ArrivalAirport).WithMany(p => p.ArrivalFlights).HasForeignKey(p => p.ArrivalAirportId);
            //HasRequired(p => p.ArrivalTerminal).WithMany(p => p.ArrivalFlights).HasForeignKey(p => p.ArrivalTerminalId);
            //HasRequired(p => p.ArrivalGate).WithMany(p => p.ArrivalFlights).HasForeignKey(p => p.ArrivalGateId);
            //HasRequired(p => p.DepartureAirport).WithMany(p => p.ArrivalFlights).HasForeignKey(p => p.DepartureAirportId);
            //HasRequired(p => p.DepartureTerminal).WithMany(p => p.ArrivalFlights).HasForeignKey(p => p.DepartureTerminalId);
            //HasRequired(p => p.DepartureGate).WithMany(p => p.ArrivalFlights).HasForeignKey(p => p.DepartureGateId);
        }
    }
}