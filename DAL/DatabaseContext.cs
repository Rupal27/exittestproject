using DAL.Domain;

using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace DAL
{
    public class DatabaseContext : DbContext
    {

        public DatabaseContext() : base("ConsensusDatabase")
        {
        }

        public DbSet<HouseListing> HouseListings { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<PopulationRegistration> PopulationRegistrations { get; set; }
        public DbSet<UserRequestStatus> UserRequestStatuss { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}