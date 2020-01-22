using Microsoft.EntityFrameworkCore;

namespace EFCoreTest
{
    public class ApplicationContext: DbContext
    {
        public DbSet<Message> Messages { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EFCoreTestDB;Trusted_Connection=True;");
        }
    }
}
