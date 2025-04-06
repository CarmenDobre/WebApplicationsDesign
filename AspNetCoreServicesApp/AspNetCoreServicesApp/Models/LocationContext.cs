using Microsoft.EntityFrameworkCore;

namespace AspNetCoreServicesApp.Models;

public class LocationContext : DbContext
{
    public LocationContext(DbContextOptions<LocationContext> options)
        : base(options)
    { }

    public DbSet<Location>? Locations { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Location>().HasData(
            new Location { LocationId = 1, IsNumber = true, LocationName = "Location 1" },
            new Location { LocationId = 2, IsNumber = false, LocationName = "Location 2" }
        );
    }
}
