using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BungieCordBlogWebAPI.Data
{
    public class AuthDbContext : IdentityDbContext
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var readerRoleId = "38e75b6c-b8ec-4951-c481-946a2f8e8642";
            var writerRoleId = "a850f27d-35b2-5335-b8cf-2cc11c8d7904";


            // Create Reader and Writer Role
            var roles = new List<IdentityRole>
            {
                new IdentityRole()
                {
                    Id = readerRoleId,
                    Name = "Reader",
                    NormalizedName = "Reader".ToUpper(),
                    ConcurrencyStamp = readerRoleId
                },
                new IdentityRole()
                {
                    Id = writerRoleId,
                    Name = "Writer",
                    NormalizedName = "Writer".ToUpper(),
                    ConcurrencyStamp = writerRoleId
                }
            };

            // Seed the roles
            builder.Entity<IdentityRole>().HasData(roles);


            // Create an Admin User
            var adminUserId = "f3d378fd-e54d-5f4c-9219-b2b2f92a017e";
            var admin = new IdentityUser()
            {
                Id = adminUserId,
                UserName = "admin@BungieCordBlog.com",
                Email = "admin@BungieCordBlog.com",
                NormalizedEmail = "admin@BungieCordBlog.com".ToUpper(),
                NormalizedUserName = "admin@BungieCordBlog.com".ToUpper()
            };

            admin.PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(admin, "Password@6969");

            builder.Entity<IdentityUser>().HasData(admin);

            // Give Roles To Admin

            var adminRoles = new List<IdentityUserRole<string>>()
            {
                new()
                {
                    UserId = adminUserId,
                    RoleId = readerRoleId
                },
                new()
                {
                    UserId = adminUserId,
                    RoleId = writerRoleId
                }
            };

            builder.Entity<IdentityUserRole<string>>().HasData(adminRoles);
        }
    }
}
