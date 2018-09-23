using System.Data.Entity.ModelConfiguration;

namespace B_FlyDB.Model
{
    public class SeatConfiguration : EntityTypeConfiguration<Seat>
    {
        public SeatConfiguration()
        {
            Property(p => p.Row).IsRequired();
            Property(p => p.Columnn).IsRequired();
        }
    }
}