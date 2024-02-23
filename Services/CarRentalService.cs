using System.Collections.Generic;
using booking.Models;

namespace booking.Services
{
    public class CarRentalService
    {
        // Mock method to simulate car rental search
        public List<CarRental> SearchCarRentals(CarRentalSearchModel searchModel)
        {
            // Implement your car rental search logic here
            // For demonstration purposes, let's return a list of dummy car rentals
            return new List<CarRental>
            {
                new CarRental { Id = 1, Location = searchModel.Location, PickupDate = searchModel.PickupDate, ReturnDate = searchModel.ReturnDate },
                new CarRental { Id = 2, Location = searchModel.Location, PickupDate = searchModel.PickupDate, ReturnDate = searchModel.ReturnDate },
                // Add more car rentals as needed
            };
        }
    }
}
