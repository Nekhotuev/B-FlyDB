using System.Data.Entity.ModelConfiguration;
using Core.Model;

namespace Data.Configurations
{
    public class AirportSchemeConfiguration : EntityTypeConfiguration<AirportScheme>
    {
        public AirportSchemeConfiguration()
        {
            Property(p => p.AirportId).IsOptional();
            Property(p => p.GateId).IsOptional();
            Property(p => p.TerminalId).IsOptional();
        }
    }
}