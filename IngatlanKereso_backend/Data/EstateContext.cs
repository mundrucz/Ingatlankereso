using Microsoft.EntityFrameworkCore;
namespace IngatlanKereso_backend.Data
{

    public class EstateContext : DbContext
    {
        public EstateContext(DbContextOptions options) : base(options) { }
        public DbSet<Estate> Estates { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estate>().ToTable("Estates");
            modelBuilder.Entity<User>().ToTable("Users");
        }
    }
}
