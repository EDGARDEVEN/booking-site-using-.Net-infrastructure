namespace booking.Models
{
    public class CarRentalSearchModel
    {
        public string Location { get; set; }
        public DateTime PickupDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}