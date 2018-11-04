using System.Data.Entity.ModelConfiguration;
using Core.Model;

namespace Core.Configurations
{
    public class ReservationConfiguration : EntityTypeConfiguration<Reservation>
    {
        public ReservationConfiguration()
        {
            Property(p => p.Booked).IsRequired();
            Property(p => p.PreBookedSeatRow).IsRequired();
            Property(p => p.PreBookedSeatColumn).IsRequired().HasMaxLength(1);
            Property(p => p.Paid).IsRequired();
            Property(p => p.RegisteredSeatRow).IsRequired();
            Property(p => p.RegisteredSeatColumn).IsRequired().HasMaxLength(1);
            Property(p => p.ExtraLuggageAmount).IsRequired();
            Property(p => p.BookedDate).IsRequired();
            Property(p => p.PaidDate).IsOptional();
            Property(p => p.FinalTicketPrice).IsRequired().HasPrecision(11,2);
        }
    }
}