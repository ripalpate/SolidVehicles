using System;
using System.Collections.Generic;
using SolidVehicles.Models;

namespace SolidVehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            // Build a collection of all vehicles that fly
            var AirVehicles = new List<AirVehicles>();
            AirVehicles.Add(new AirVehicles("Helicopter", 1, 2, 4, 5, true, 350));
            AirVehicles.Add(new AirVehicles("Cessana", 31.1, 3, 3, 113, true, 309.0));

            // With a single `foreach`, have each vehicle Fly()
            foreach (var airVehicle in AirVehicles)
            {
                airVehicle.Start();
                airVehicle.Fly();
                airVehicle.PrintAirVehicleInfo();
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
    }
}
