using Microsoft.AspNetCore.Mvc;
using booking.Models;
using System.Collections.Generic;
using booking.Services;
using booking.Data;
using System;


namespace booking.Controllers
{
    public class TravelController : Controller
    {
    private readonly FlightService _flightService;
    private readonly HotelService _hotelService;
    private readonly CarRentalService _carRentalService;

    public TravelController(FlightService flightService, HotelService hotelService, CarRentalService carRentalService)
    {
        _flightService = flightService ?? throw new System.ArgumentNullException(nameof(flightService));
        _hotelService = hotelService ?? throw new System.ArgumentNullException(nameof(hotelService));
        _carRentalService = carRentalService ?? throw new System.ArgumentNullException(nameof(carRentalService));
    }

    // Other controller actions

    public IActionResult FlightSearch()
    {
        return View();
    }

    [HttpPost]
    public IActionResult SearchFlights(FlightSearchModel model)
    {
        var flights = _flightService.SearchFlights(model);
        return View("FlightResults", flights);
    }

    public IActionResult HotelSearch()
    {
        return View();
    }

    [HttpPost]
    public IActionResult SearchHotels(HotelSearchModel model)
    {
        var hotels = _hotelService.SearchHotels(model);
        return View("HotelResults", hotels);
    }

    public IActionResult CarRentalSearch()
    {
        return View();
    }

    [HttpPost]
    public IActionResult SearchCarRentals(CarRentalSearchModel model)
    {
        var carRentals = _carRentalService.SearchCarRentals(model);
        return View("CarRentalResults", carRentals);
    }
    }
}
