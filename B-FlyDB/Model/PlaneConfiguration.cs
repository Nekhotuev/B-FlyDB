using System.Data.Entity.ModelConfiguration;

namespace B_FlyDB.Model
{
    public class PlaneConfiguration : EntityTypeConfiguration<Plane>
    {
        public PlaneConfiguration()
        {
            Property(p => p.PlaneModel).IsRequired().HasMaxLength(30);
            Property(p => p.PlaneModification).IsRequired().HasMaxLength(20);
            Property(p => p.FirstECSeat).IsRequired();
            Property(p => p.LastECSeat).IsRequired();
            Property(p => p.FirstECSeatRow).IsRequired();
            Property(p => p.LastECSeatRow).IsRequired();
        }
    }
}