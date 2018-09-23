using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace B_FlyDB.Model
{
    public class IdConvention : Convention
    {
        public IdConvention()
        {
            Properties<Guid>().Where(p => p.Name == "Id").Configure(p => p.HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity));
        }
    }
}