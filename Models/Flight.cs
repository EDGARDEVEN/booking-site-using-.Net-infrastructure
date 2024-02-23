public class Flight
{
    public int Id { get; set; }
    public string FlightNumber { get; set; }
    public string? Airline { get; set; }
    public DateTime DepartureTime { get; set; }
    public DateTime ArrivalTime { get; set; }
    public decimal Price { get; set; }
    public string Origin { get; set; }
    public string Destination { get; set; }
    public DateTime DepartureDate { get; set; }


    // Add other properties as needed
}