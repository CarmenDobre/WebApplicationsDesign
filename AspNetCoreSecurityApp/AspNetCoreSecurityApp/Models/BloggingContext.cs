using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreSecurityApp.Models
{
    public class BloggingContext : IdentityDbContext<IdentityUser>
    {
        public BloggingContext(DbContextOptions<BloggingContext> options)
        : base(options)
        { }

        public DbSet<Blog>? Blogs { get; set; }
        public DbSet<Post>? Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "e492ef42-6f68-4a9d-b348-8e7b8886eeb9", Name = "Administrator", NormalizedName = "ADMINISTRATOR" },
                new IdentityRole { Id = "bf8d6d3c-7e58-47dd-a3e6-96198d574fcd", Name = "User", NormalizedName = "USER" }
            );
        }

    }
}
