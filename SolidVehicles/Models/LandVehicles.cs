using SolidVehicles.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles.Models
{
    public abstract class LandVehicles:ILandVehicle
    {
        public double EngineVolume { get; set; }
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public int PassengerCapacity { get; set; }
        public string TransmissionType { get; set; }
        public double MaxLandSpeed { get; set; } = 160.4;

        public LandVehicles( double engineVolume, int wheels, int doors, int passengerCapacity, string transmissionType, double maxLandSpeed)
        {
            EngineVolume = engineVolume;
            Wheels = wheels;
            Doors = doors;
            PassengerCapacity = passengerCapacity;
            TransmissionType = transmissionType;
   
        }
        public virtual void Drive()
        {
            Console.WriteLine($" screams down the highway with maximum {MaxLandSpeed} speed.");
        }

        public void Start()
        {
            Console.WriteLine($" has an ability for auto start which comes with {TransmissionType} transmission.");
        }

        public void Stop()
        {
            Console.WriteLine($" stops when you brake.");
        }

        public void PrintLandVehicleInfo()
        {
            Console.WriteLine($"This vehicle has {Wheels} wheels and {Doors} doors with {PassengerCapacity} passenger capacity.");
        }
    }
}
