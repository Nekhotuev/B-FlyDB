using System.Data.Entity.ModelConfiguration;

namespace Core.Configuration
{
    public class AirportConfiguration : EntityTypeConfiguration<Airport>
    {
        public AirportConfiguration()
        {
            Property(p => p.Code).IsRequired().HasMaxLength(20);
        }
    }
}