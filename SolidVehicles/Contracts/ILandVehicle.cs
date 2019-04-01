using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles.Contracts
{
    public interface ILandVehicle:IVehicle
    {
        int Doors { get; set; }
        string TransmissionType { get; set; }
        double MaxLandSpeed { get; set; }
        void Drive();
    }
}
