using SolidVehicles.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles.Models
{
    abstract class WaterVehicles: IWaterVehicle
    {
        //public string Name { get; set; }
        public int Wheels { get; set; }
        public int PassengerCapacity { get; set; }
        public string TransmissionType { get; set; }
        public double MaxWaterSpeed { get; set; }
        public double EngineVolume { get; set; }

        public WaterVehicles(double engineVolume, int wheels, int passengerCapacity, string transmissionType, double maxWaterSpeed)
        {
            EngineVolume = engineVolume;
            Wheels = wheels;
            PassengerCapacity = passengerCapacity;
            TransmissionType = transmissionType;
            MaxWaterSpeed = maxWaterSpeed;
        }

        public virtual void Drive()
        {
        }

        public void Start()
        {
            Console.WriteLine($"start by pushing start button");
        }
        public void Stop()
        {
            Console.WriteLine($"stops whenever you want to stop me");
        }
    }
}
