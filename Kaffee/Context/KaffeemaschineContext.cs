using KaffeemaschinenVar;
using Microsoft.EntityFrameworkCore;

namespace Kaffee.Context
{
    public class KaffeemaschineContext : DbContext
    {
        public DbSet<KaffeemaschineClass> Kaffeemaschine { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=KaffeemaschineDB.db;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KaffeemaschineClass>().ToTable("Kaffeemaschine");
        }
    }
}
