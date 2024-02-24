using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using booking.Data;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Microsoft.Extensions.Configuration;
using System;
using booking.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<FlightService>();
builder.Services.AddScoped<HotelService>();
builder.Services.AddScoped<CarRentalService>();



// Register DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
        new MariaDbServerVersion(new Version("10.11.6")))); // Specify MariaDB version

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "flights",
    pattern: "/flights",
    defaults: new { controller = "Travel", action = "FlightSearch" }
);

app.MapControllerRoute(
    name: "hotels",
    pattern: "/hotels",
    defaults: new { controller = "Travel", action = "HotelSearch" }
);

app.MapControllerRoute(
    name: "carRentals",
    pattern: "/car-rentals",
    defaults: new { controller = "Travel", action = "CarRentalSearch" }
);

app.MapControllerRoute(
    name: "flightResults",
    pattern: "/flights/results",
    defaults: new { controller = "Travel", action = "SearchFlights" }
);  


app.Run();
