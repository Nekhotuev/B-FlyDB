using System.Data.Entity.ModelConfiguration;
using Core.Model;

namespace Data.Configurations
{
    class CityConfiguration : EntityTypeConfiguration<City>
    {
        public CityConfiguration()
        {
            Property(p => p.CountryId).IsOptional();
        }
    }
}
