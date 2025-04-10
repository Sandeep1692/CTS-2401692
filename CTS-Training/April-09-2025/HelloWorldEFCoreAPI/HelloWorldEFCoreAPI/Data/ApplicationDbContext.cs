using HelloWorldEFCoreAPI.Model.Domain;
using Microsoft.EntityFrameworkCore;

namespace HelloWorldEFCoreAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<BlogPost> BlogPosts { get; set; }
    }
}
