using SolidVehicles.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles.Models
{
    class LandVehicles:ILandVehicle
    {
        public string Name { get; set; }
        public double EngineVolume { get; set; }
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public int PassengerCapacity { get; set; }
        public string TransmissionType { get; set; }
        public double MaxLandSpeed { get; set; } = 160.4;

        public LandVehicles(string name, double engineVolume, int wheels, int doors, int passengerCapacity, string transmissionType, double maxLandSpeed)
        {
            Name = name;
            EngineVolume = engineVolume;
            Wheels = wheels;
            Doors = doors;
            PassengerCapacity = passengerCapacity;
            TransmissionType = transmissionType;
            MaxLandSpeed = maxLandSpeed;
        }
        public void Drive()
        {
            Console.WriteLine($"{Name} screams down the highway with maximum {MaxLandSpeed} speed.");
        }

        public void Start()
        {
            Console.WriteLine($"{Name} has an ability for auto start which comes with {TransmissionType} transmission.");
        }

        public void Stop()
        {
            Console.WriteLine($"{Name} stops when you brake.");
        }
        public void PrintLandVehicleInfo()
        {
            Console.WriteLine($"{Name} has {Wheels} wheels and {Doors} doors with {PassengerCapacity} passenger capacity.");
        }
    }
}
