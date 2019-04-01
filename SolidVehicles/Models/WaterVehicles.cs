using SolidVehicles.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles.Models
{
    class WaterVehicles: IWaterVehicle
    {
        public string Name { get; set; }
        public int Wheels { get; set; }
        public int PassengerCapacity { get; set; }
        public string TransmissionType { get; set; }
        public double MaxWaterSpeed { get; set; }
        public double EngineVolume { get; set; }

        public WaterVehicles(string name, double engineVolume, int wheels, int passengerCapacity, string transmissionType, double maxWaterSpeed)
        {
            Name = name;
            EngineVolume = engineVolume;
            Wheels = wheels;
            PassengerCapacity = passengerCapacity;
            TransmissionType = transmissionType;
            MaxWaterSpeed = maxWaterSpeed;
        }

        public void Drive()
        {
            Console.WriteLine($"{Name} zips through the waves with the greatest of ease");
        }

        public void Start()
        {
            Console.WriteLine($"{Name} start by pushing start button");
        }
        public void Stop()
        {
            Console.WriteLine($"{Name} stops whenever you want to stop me");
        }
        public void PrintWaterVehicleInfo()
        {
            Console.WriteLine($"{Name} has {Wheels} wheels with {PassengerCapacity} passenger capacity.");
        }
    }
}
