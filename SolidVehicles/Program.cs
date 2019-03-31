using System;
using System.Linq;
using System.Collections.Generic;

namespace SolidVehicles
{
    public interface IVehicle
    {
        string Name { get; set; }
        int PassengerCapacity { get; set; }
        int Wheels { get; set; }
        double EngineVolume { get; set; }
        void Start();
        void Stop();
    }
    public interface ILandVehicle :IVehicle
    { // an int property called Wheels // an int property called Doors // an int property called PassengerCapacity // a bool property called Winged // a string property called TransmissionType // a double property called EngineVolume // a double property called MaxWaterSpeed // a double property called MaxLandSpeed // a double property called MaxAirSpeed // a method called Start() that returns void // a method called Stop() that returns void // a method called Drive() that returns void // a method called Fly() that returns void
        int Doors { get; set; }
        string TransmissionType { get; set; }
        double MaxLandSpeed { get; set; }
        void Drive();
    }

    public interface IAirVehicle :IVehicle
    {
        int Doors { get; set; }
        bool Winged { get; set; }
        double MaxAirSpeed { get; set; }
        void Fly();
    }


    public interface IWaterVehicle : IVehicle 
    {
        string TransmissionType { get; set; }
        double MaxWaterSpeed { get; set; }
        void Drive();
    }

    public class WaterVehicles : IWaterVehicle
    {
        public string Name { get; set; }
        public int Wheels { get; set; }
        public int PassengerCapacity { get; set ; }
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

    public class LandVehicles : ILandVehicle
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

    public class AirVehicles : IAirVehicle
    {
        public int Wheels { get; set; } = 3;
        public int Doors { get; set; } 
        public int PassengerCapacity { get; set; }
        public bool Winged { get; set; } = true;
        public string TransmissionType { get; set; } = "None";
        public double MaxAirSpeed { get; set; } = 309.0;
        public string Name { get; set ; }
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


    class Program
    {
        static void Main(string[] args)
        {
            // Build a collection of all vehicles that fly
            var AirVehicles = new List<AirVehicles>();
            AirVehicles.Add(new AirVehicles("Helicopter", 1, 2, 4, 5, true, 350));
            AirVehicles.Add(new AirVehicles("Cessana", 31.1, 3, 3, 113, true, 309.0));
            // With a single `foreach`, have each vehicle Fly()
            foreach (var AirVehicle in AirVehicles)
            {
                AirVehicle.Start();
                AirVehicle.Fly();
                AirVehicle.PrintAirVehicleInfo();
            }
            
            // Build a collection of all vehicles that operate on roads
            var LandVehicles = new List<LandVehicles>();
            LandVehicles.Add(new LandVehicles("Compact", 1.5, 4, 4, 5, "Auto", 110));
            LandVehicles.Add(new LandVehicles("MotorCycle", 1.2, 0, 0, 2, "Manual", 100));

            // With a single `foreach`, have each road vehicle Drive()
            foreach (var LandVehicle in LandVehicles)
            {
                LandVehicle.Start();
                LandVehicle.Drive();
                LandVehicle.PrintLandVehicleInfo();
            }


            // Build a collection of all vehicles that operate on water
            var WaterVehicles = new List<WaterVehicles>();
            WaterVehicles.Add(new WaterVehicles("JetSki", 1.3,1,7,"Auto", 100));

            // With a single `foreach`, have each water vehicle Drive()
            foreach (var WaterVehicle in WaterVehicles)
            {
                WaterVehicle.Start();
                WaterVehicle.Drive();
                WaterVehicle.PrintWaterVehicleInfo();
            }
            Console.ReadLine();

        }
   
        //public static List<IVehicle> AddVehicles()
        //{
        //    var ListOfVehicles = new List<IVehicle>();
        //    ListOfVehicles.Add(new LandVehicles("Compact", 1.5, 4, 4, 5, "Auto", 110));
        //    ListOfVehicles.Add(new LandVehicles("MotorCycle", 1.2, 0, 0, 2, "Manual", 100));
        //    ListOfVehicles.Add(new AirVehicles("Helicopter", 1, 2, 4, 5, true, 150));

        //}
    }
}
