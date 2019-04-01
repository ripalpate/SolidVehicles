using SolidVehicles.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles.Models
{
    class AirVehicles: IAirVehicle
    {
        public int Wheels { get; set; } = 3;
        public int Doors { get; set; }
        public int PassengerCapacity { get; set; }
        public bool Winged { get; set; } = true;
        public string TransmissionType { get; set; } = "None";
        public double MaxAirSpeed { get; set; } = 309.0;
        public string Name { get; set; }
        public double EngineVolume { get; set; }

        public AirVehicles(string name, double engineVolume, int wheels, int doors, int passengerCapacity, bool winged, double maxAirSpeed)
        {
            Name = name;
            EngineVolume = engineVolume;
            Wheels = wheels;
            Doors = doors;
            PassengerCapacity = passengerCapacity;
            Winged = winged;
            MaxAirSpeed = maxAirSpeed;
        }
        public void Fly()
        {
            Console.WriteLine($"{Name} effortlessly glides through the clouds like a gleaming god of the Sun");
        }

        public void Start()
        {
            Console.WriteLine($"{Name} start with ease and it can go to the maximum speed of {MaxAirSpeed}");
        }

        public void Stop()
        {
            Console.WriteLine($"{Name} stops on landing");
        }
        public void PrintAirVehicleInfo()
        {
            Console.WriteLine($"{Name} has {Wheels} wheels and {Doors} doors with {PassengerCapacity} passenger capacity.");
        }
    }
}
