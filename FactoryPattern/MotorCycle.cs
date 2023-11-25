using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class MotorCycle : IVehicle
    {
        public MotorCycle() { }
        public void Drive()
        {
            Console.WriteLine("This is for a motorcycle");
        }
    }
}
