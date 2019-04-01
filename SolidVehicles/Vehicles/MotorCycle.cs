using SolidVehicles.Contracts;
using SolidVehicles.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles.Vehicles
{
    class MotorCycle:LandVehicles, ILandVehicle
    {
        public MotorCycle(double engineVolume, int wheels, int doors, int passengerCapacity, string transmissionType, double maxLandSpeed)
            : base(engineVolume, wheels, doors, passengerCapacity, transmissionType, maxLandSpeed)
        {
        }

        public override void Drive()
        {
            Console.WriteLine($"Motorcycle screams down the highway with maximum of {MaxLandSpeed} speed.");
        }
    }
}
