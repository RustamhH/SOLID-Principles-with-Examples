using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles_With_Examples.Interface_Segregation
{
    internal interface ISailingMachineG
    {
        public void Sail();
    }
    internal interface ISailingMachineWithEngineG
    {
        public void StartEngines();
    }

    internal class ShipG : ISailingMachineG, ISailingMachineWithEngineG
    {
        public void Sail()
        {
            Console.WriteLine("Sailing...");
        }

        public void StartEngines()
        {
            Console.WriteLine("Starting the engines...");
        }
    }


    internal class BoatG : ISailingMachineG
    {
        public void Sail()
        {
            Console.WriteLine("Sailing...");
        }
    }
}
