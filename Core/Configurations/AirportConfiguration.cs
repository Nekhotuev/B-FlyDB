using System.Data.Entity.ModelConfiguration;
using Core.Model;

namespace Core.Configurations
{
    public class AirportConfiguration : EntityTypeConfiguration<Airport>
    {
        public AirportConfiguration()
        {
            Property(p => p.Code).IsRequired().HasMaxLength(20);
        }
    }
}