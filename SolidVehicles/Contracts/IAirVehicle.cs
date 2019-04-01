using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles.Contracts
{
    interface IAirVehicle: IVehicle
    {
        int Doors { get; set; }
        bool Winged { get; set; }
        double MaxAirSpeed { get; set; }
        void Fly();
    }
}
