using System;
using System.Collections.Generic;
using SolidVehicles.Models;
using SolidVehicles.Vehicles;

namespace SolidVehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            // Build a collection of all vehicles that fly
            var ListOfAirVehicles = new List<AirVehicles>();
            var cessna = new Cessna(31.1, 3, 3, 113, true, 309.0);
            ListOfAirVehicles.Add(cessna);

            // With a single `foreach`, have each vehicle Fly()
            foreach (var airVehicle in ListOfAirVehicles)
            {
                airVehicle.Fly();
            }

            // Build a collection of all vehicles that operate on roads
            var ListOfLandVehicles = new List<LandVehicles>();
            var car = new Car(4, 4, 5, "Auto", 160.4);
            var motorcycle = new MotorCycle(1.3, 2, 0, 2, "Manual", 160.4);
            ListOfLandVehicles.Add(car);
            ListOfLandVehicles.Add(motorcycle);
            // With a single `foreach`, have each road vehicle Drive()
            foreach (var landVehicle in ListOfLandVehicles)
            {
                landVehicle.Drive();
                landVehicle.PrintLandVehicleInfo();
            }

            // Build a collection of all vehicles that operate on water
            var ListOfWaterVehicles = new List<WaterVehicles>();
            var jetski = new JetSki(1.6, 2, 2, "Auto", 150);
            var boat = new Boat(1.4, 0, 4, "Manual", 40.5);
            ListOfWaterVehicles.Add(jetski);
            ListOfWaterVehicles.Add(boat);
            // With a single `foreach`, have each water vehicle Drive()
            foreach (var waterVehicle in ListOfWaterVehicles)
            {
                waterVehicle.Drive();
            }

            Console.ReadLine();

        }
    }
}
