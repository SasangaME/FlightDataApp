using FlightData.Models.Entities;

namespace FlightData.Db.DbContext;
using Microsoft.EntityFrameworkCore;

public class FlightDataContext(DbContextOptions<FlightDataContext> options) : DbContext(options)
{
    public DbSet<Location> Locations { get; set; }
    public DbSet<FlightDetails> FlightDetails { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<FlightDetails>()
            .HasOne(r => r.Origin)
            .WithMany()
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<FlightDetails>()
            .HasOne(r => r.Destination)
            .WithMany()
            .OnDelete(DeleteBehavior.NoAction);
    }

}