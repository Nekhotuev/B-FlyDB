using System.Data.Entity;
using B_FlyDB.Model;

namespace B_FlyDB.DAL
{
    public class UserContext : DbContext
    {
        public UserContext() : base("DefaultConnection")
        { }

        public DbSet<City> Cities { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Conventions.Add(new IdConvention());
            modelBuilder.Conventions.Add(new NameConvention());
        }
    }
}