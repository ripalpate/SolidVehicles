using SolidVehicles.Contracts;
using SolidVehicles.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles.Vehicles
{
    class Boat : WaterVehicles, IWaterVehicle
    {
        public Boat(double engineVolume, int wheels, int passengerCapacity, string transmissionType, double maxWaterSpeed)
           : base(engineVolume, wheels, passengerCapacity, transmissionType, maxWaterSpeed)
        {
        }


        public override void Drive()
        {
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine($"Boat goes smoothly");
        }
    }
}
