using Microsoft.EntityFrameworkCore;
using OneToManyDemo.Models.Domain;

namespace OneToManyDemo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Zoo> Zoos { get; set; }
        public DbSet<Animal> Animals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure the relationship between Zoo and Animal
            modelBuilder.Entity<Animal>()
                .HasOne(a => a.Zoo)
                .WithMany(z => z.Animals)
                .HasForeignKey(a => a.ZooId);
        }
    }
}