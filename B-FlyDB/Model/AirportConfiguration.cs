using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace B_FlyDB.Model
{
    public class AirportConfiguration : EntityTypeConfiguration<Airport>
    {
        public AirportConfiguration()
        {
            Property(p => p.Code).IsRequired().HasMaxLength(20);
        }
    }
}