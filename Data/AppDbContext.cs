using Microsoft.EntityFrameworkCore;
using booking.Models;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using System;

namespace booking.Data
{
public class AppDbContext : DbContext
{
    public DbSet<Flight> Flights { get; set; }
    public DbSet<Hotel> Hotels { get; set; }
    public DbSet<CarRental> CarRentals { get; set; }
    public DbSet<Booking> Bookings { get; set; }

     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseMySql("Server=localhost, 3306; Database=booking2; User Id=root; Password=8257;",
                new MariaDbServerVersion(new Version("10.11.6")));
        }
    }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
}
}