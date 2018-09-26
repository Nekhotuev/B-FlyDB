using System.Data.Entity.ModelConfiguration;

namespace B_FlyDB.Model
{
    public class ReservationConfiguration : EntityTypeConfiguration<Reservation>
    {
        public ReservationConfiguration()
        {
            Property(p => p.Row).IsRequired();
            Property(p => p.Columnn).IsRequired();
        }
    }
}