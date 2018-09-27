using System.Data.Entity.ModelConfiguration;

namespace B_FlyDB.Model
{
    public class PlaneConfiguration : EntityTypeConfiguration<Plane>
    {
        public PlaneConfiguration()
        {
            Property(p => p.PlaneModel).IsRequired();
            Property(p => p.PlaneModification).IsRequired();
            Property(p => p.FirstBCSeat).IsRequired().HasMaxLength(1);
            Property(p => p.LastBCSeat).IsRequired().HasMaxLength(1);
            Property(p => p.FirstBCSeatRow).IsRequired();
            Property(p => p.LastBCSeatRow).IsRequired();
            Property(p => p.FirstECSeat).IsRequired().HasMaxLength(1);
            Property(p => p.LastECSeat).IsRequired().HasMaxLength(1);
            Property(p => p.FirstECSeatRow).IsRequired();
            Property(p => p.LastECSeatRow).IsRequired();
            Property(p => p.FuelConsumptionOnOneMile).IsRequired();
        }
    }
}