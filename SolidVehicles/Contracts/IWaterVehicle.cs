using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles.Contracts
{
    interface IWaterVehicle: IVehicle
    {
        string TransmissionType { get; set; }
        double MaxWaterSpeed { get; set; }
        void Drive();
    }
}
