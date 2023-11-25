using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(string numberOfTires)
        {
          switch (numberOfTires)
            {
                case "2":
                    return new MotorCycle();
                    case "4":
                    return new Truck();
                default:
                    return new Unicycle();
            }
        }
    }
}
