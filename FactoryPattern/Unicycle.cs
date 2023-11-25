using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Unicycle : IVehicle
    {
        public Unicycle() { }

        public void Drive()
        {
            Console.WriteLine("Probably a Unicycle idk");
        }
    }
}
