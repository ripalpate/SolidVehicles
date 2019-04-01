using SolidVehicles.Contracts;
using SolidVehicles.Models;
using System;

namespace SolidVehicles.Vehicles
{
    public class Car: LandVehicles
    {
        public Car( int wheels, int doors, int passengerCapacity, string transmissionType, double maxLandSpeed) 
            : base(1.5, wheels, doors, passengerCapacity, transmissionType, maxLandSpeed)
        {
        }

        public override void Drive()
        {
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine($"Car screams down the highway with maximum of {MaxLandSpeed} speed.");
        }

    }
}
