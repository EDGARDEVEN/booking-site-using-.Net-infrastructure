using System.Collections.Generic;
using booking.Models;


namespace booking.Services
{
    public class FlightService
    {
        // Mock method to simulate flight search
        public List<Flight> SearchFlights(FlightSearchModel searchModel)
        {
            // Implement your flight search logic here
            // For demonstration purposes, let's return a list of dummy flights
            return new List<Flight>
            {
                new Flight { Id = 1, Origin = "New York", Destination = "Los Angeles", DepartureDate = searchModel.DepartureDate },
                new Flight { Id = 2, Origin = "Los Angeles", Destination = "New York", DepartureDate = searchModel.DepartureDate },
                new Flight { Id = 3, Origin = "New York", Destination = "Chicago", DepartureDate = searchModel.DepartureDate },
                new Flight { Id = 4, Origin = "Chicago", Destination = "New York", DepartureDate = searchModel.DepartureDate },
                
                // Add more flights as needed
            };
        }
    }
}
