using System.Data.Entity.ModelConfiguration;
using Core.Model;

namespace Core.Configurations
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            Property(p => p.Login).IsRequired().HasMaxLength(50);
            Property(p => p.Password).IsRequired().HasMaxLength(50);
            Property(p => p.FirstName).IsRequired().HasMaxLength(30);
            Property(p => p.LastName).IsRequired().HasMaxLength(30);
            Property(p => p.BirthDate).IsRequired();
            Property(p => p.Title).IsRequired().HasMaxLength(10);
            Property(p => p.Zipcode).IsRequired();
            Property(p => p.Address).IsRequired().HasMaxLength(150);
            Property(p => p.PassportId).IsRequired().HasMaxLength(20);
            Property(p => p.PhoneNumber).IsRequired().HasMaxLength(20);
            Property(p => p.Email).IsRequired().HasMaxLength(50);
        }
    }
}