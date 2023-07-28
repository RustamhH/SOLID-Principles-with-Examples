using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles_With_Examples.Interface_Segregation
{
    internal interface ISailingMachineB
    {
        public void StartEngines();
        public void Sail();
    }

    internal class ShipB : ISailingMachineB
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


    // Class is containing a function that it doesn't need.

    internal class BoatB : ISailingMachineB
    {
        public void Sail()
        {
            Console.WriteLine("Sailing...");
        }



        public void StartEngines()
        {
            throw new NotImplementedException("Boats dont have engines");
        }
    }


}
