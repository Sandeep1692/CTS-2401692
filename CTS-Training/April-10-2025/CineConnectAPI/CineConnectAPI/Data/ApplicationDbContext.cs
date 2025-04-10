using Microsoft.EntityFrameworkCore;
using CineConnectAPI.Models.Domain;
namespace CineConnectAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Theatre> Theatres { get; set; }
        public DbSet<Movie> Movies { get; set; }

        //public DbSet<BlogPost> BlogPosts { get; set; }
        //public DbSet<Category> Categories { get; set; }
        //public DbSet<BlogImage> BlogImages { get; set; }
    }
}
