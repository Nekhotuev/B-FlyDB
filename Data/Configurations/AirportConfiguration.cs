using System.Data.Entity.ModelConfiguration;
using Core.Model;

namespace Data.Configurations
{
    public class AirportConfiguration : EntityTypeConfiguration<Airport>
    {
        public AirportConfiguration()
        {
            Property(p => p.Code).IsRequired().HasMaxLength(20);
            Property(p => p.CityId).IsOptional();
        }
    }
}