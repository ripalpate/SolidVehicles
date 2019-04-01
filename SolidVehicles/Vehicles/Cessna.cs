using SolidVehicles.Contracts;
using SolidVehicles.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles.Vehicles
{
    class Cessna:AirVehicles,IAirVehicle
    {
        public Cessna(double engineVolume, int wheels, int doors, int passengerCapacity, bool winged, double maxAirSpeed) 
            : base(engineVolume, wheels, doors, passengerCapacity, winged, maxAirSpeed)
        {
        }
        public override void Fly()
        {
            Console.WriteLine($"Cessna effortlessly glides through the clouds like a gleaming god of the Sun");
        }
    }
}
