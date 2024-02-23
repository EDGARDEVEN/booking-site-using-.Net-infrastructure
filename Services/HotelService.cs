using System.Collections.Generic;
using booking.Models;

namespace booking.Services
{
    public class HotelService
    {
        // Mock method to simulate hotel search
        public List<Hotel> SearchHotels(HotelSearchModel searchModel)
        {
            // Implement your hotel search logic here
            // For demonstration purposes, let's return a list of dummy hotels
            return new List<Hotel>
            {
                new Hotel { Id = 1, Name = "Example Hotel", City = searchModel.City, CheckInDate = searchModel.CheckInDate, CheckOutDate = searchModel.CheckOutDate },
                new Hotel { Id = 2, Name = "Another Hotel", City = searchModel.City, CheckInDate = searchModel.CheckInDate, CheckOutDate = searchModel.CheckOutDate },
                // Add more hotels as needed
            };
        }
    }
}
