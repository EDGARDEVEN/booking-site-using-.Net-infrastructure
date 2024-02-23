public class CarRental
{
    public int Id { get; set; }
    public string? Company { get; set; }
    public string? Model { get; set; }
    public string? Location { get; set; }
    public decimal Price { get; set; }
    public DateTime PickupDate { get; set; }
    public DateTime ReturnDate { get; set; }
    // Add other properties as needed
}