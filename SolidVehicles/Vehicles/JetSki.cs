using SolidVehicles.Contracts;
using SolidVehicles.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles.Vehicles
{
    class JetSki: WaterVehicles, IWaterVehicle
    {
        public JetSki(double engineVolume, int wheels, int passengerCapacity, string transmissionType, double maxWaterSpeed) 
            : base(engineVolume, wheels, passengerCapacity, transmissionType, maxWaterSpeed)
        {
        }


        public override void Drive()
        {
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine($"Jetski zips through the waves with the greatest of ease");
        }

    }
}
