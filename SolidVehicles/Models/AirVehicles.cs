using SolidVehicles.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles.Models
{
    abstract class AirVehicles: IAirVehicle
    {
        public int Wheels { get; set; } = 3;
        public int Doors { get; set; }
        public int PassengerCapacity { get; set; }
        public bool Winged { get; set; } = true;
        public string TransmissionType { get; set; } = "None";
        public double MaxAirSpeed { get; set; } = 309.0;
        public double EngineVolume { get; set; }

        public AirVehicles(double engineVolume, int wheels, int doors, int passengerCapacity, bool winged, double maxAirSpeed)
        {
            EngineVolume = engineVolume;
            Wheels = wheels;
            Doors = doors;
            PassengerCapacity = passengerCapacity;
            Winged = winged;
            MaxAirSpeed = maxAirSpeed;
        }
        public virtual void Fly(){ }

        public void Start()
        {
            Console.WriteLine($"start with ease and it can go to the maximum speed of {MaxAirSpeed}");
        }

        public void Stop()
        {
            Console.WriteLine($"stops on landing");
        }

        public void PrintAirVehicleInfo()
        {
            Console.WriteLine($"has {Wheels} wheels with {PassengerCapacity} passenger capacity.");
        }

    }
}
