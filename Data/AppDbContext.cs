public class AppDbContext : DbContext
{
    public DbSet<Flight> Flights { get; set; }
    public DbSet<Hotel> Hotels { get; set; }
    public DbSet<CarRental> CarRentals { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
}