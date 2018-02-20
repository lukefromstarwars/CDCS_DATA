#region

using Microsoft.EntityFrameworkCore;

#endregion

namespace CDCS.Transform.Model {
    public class CdcsContext : DbContext {

        public DbSet<ActionZone> ActionZones { get; set; }
        public DbSet<OrganisationLanguage> OrganisationLanguages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conn = @"Server=(LocalDb)\MSSQLLocalDB;Database=CDCS_Import;Trusted_Connection=True;MultipleActiveResultSets=true";
            optionsBuilder.UseSqlServer(conn);
        }

    }
}