using HW4.Models;
using Microsoft.EntityFrameworkCore;

namespace HW4.Data
{
    public class VehicleDBContext : DbContext
    {
        public VehicleDBContext(DbContextOptions<VehicleDBContext> options)
       : base(options)
        {


        }

        public DbSet<Vehicle> Vehicles { get; set; }//a DBSet is a C# representation of a table. Here we are adding the books table to the DBContext Class

        protected override void OnModelCreating(ModelBuilder modelBuilder) //override the base class
        {
            modelBuilder.Entity<Vehicle>().HasData(

                new Vehicle
                {
                    VehicleId = 1,
                    Mileage = 20340,
                    DateReceived = new DateTime(2023, 10, 25),
                    DateSold = new DateTime(2023, 11, 12),
                    VehicleStatus = "Sold",
                    VIN = "4S3BMHB68B3286050",
                    Make = "Chevrolet",
                    Model = "Corvette",
                    Year = 2016
                },
                new Vehicle
                {
                    VehicleId = 2,
                    Mileage = 10,
                    DateReceived = new DateTime(),
                    DateSold = new DateTime(),
                    VehicleStatus = "In-Transit",
                    VIN = "8BYBMHB72B3286123",
                    Make = "Chevrolet",
                    Model = "Trax",
                    Year = 2023
                },
                new Vehicle
                {
                    VehicleId = 3,
                    Mileage = 67512,
                    DateReceived = new DateTime(2023, 8, 17),
                    DateSold = new DateTime(),
                    VehicleStatus = "Available",
                    VIN = "1Y3BJKE68Y45860736",
                    Make = "Ford",
                    Model = "F-150",
                    Year = 2018
                }
                );

        }
    }
}
