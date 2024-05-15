using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
var cars = new List<Car>{
    new Car( "Motorwagen", 1886),
    new Car( "DeLorean", 1982),
    new Car("Model X", 2022)
};


app.MapGet("/cars", () =>
{
   return Results.Ok(cars);
})
.WithName("cars");

app.MapGet("/car", ([FromQuery] string name) =>
{
    var car = cars.FirstOrDefault(x => x.Name.ToLower()== name.ToLower());
    if (car == default){
        return Results.NotFound();
    }
    return Results.Ok(car);
});
app.MapPost("/car", ([FromBody] Car car) =>{
    cars.Add(car);
    return Results.Created($"car/{car.Name}", car);
});

app.MapDelete("/cars", () =>{
    cars =new List<Car>();
    return Results.Ok();
});

app.Run();

