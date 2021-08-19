using System.Collections.Generic;
using Svys2nov.VHealth.Domain.Models;

namespace Svys2nov.VHealth.Domain
{
    public static class Database
    {
        public static IEnumerable<Vehicle> Vehicles => new []
        {
            new Vehicle
            {
                UserId = 777,
                VehicleId = 7771,
                Name = "Muscle Car: Chevrolet Impala"
            },
            new Vehicle
            {
                UserId = 777,
                VehicleId = 7772,
                Name = "Motorcycle: Yamaha"
            },
            new Vehicle
            {
                UserId = 777,
                VehicleId = 7773,
                Name = "Scooter: Xiaomi"
            },
            new Vehicle
            {
                UserId = 666,
                VehicleId = 6661,
                Name = "Car: Tavria Nova"
            },
            new Vehicle
            {
                UserId = 1,
                VehicleId = 11,
                Name = "Bus: Icarus"
            },
            new Vehicle
            {
                UserId = 1,
                VehicleId = 12,
                Name = "Bicycle: Ukraine"
            }
        };
    }
}