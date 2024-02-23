namespace booking.Models
{
public class Booking
{
    public int Id { get; set; }
    public string CustomerName { get; set; }
    public int UserId { get; set; }
    public DateTime BookingDate { get; set; }
    public int FlightId { get; set; }
    public int HotelId { get; set; }
    public int CarRentalId { get; set; }
    public Flight? Flight { get; set; }
    public Hotel? Hotel { get; set; }
    public CarRental? CarRental { get; set; }

}
}
