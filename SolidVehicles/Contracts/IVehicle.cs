using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles.Contracts
{
    public interface IVehicle
    {
        int PassengerCapacity { get; set; }
        int Wheels { get; set; }
        double EngineVolume { get; set; }
        void Start();
        void Stop();
    }
}
