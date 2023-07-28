using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles_With_Examples.Liskov_Substition
{
    internal abstract class LandAnimalG
    {
        public abstract void MakeNoise();
    }
    
    internal abstract class WaterAnimalG
    {
        public abstract void Swim();
    }

    // Derived class should be able to perform the same actions with its base

    class DogG : LandAnimalG
    {
        public override void MakeNoise()
        {
            Console.WriteLine("Hav");
        }
    }

    // Derived class should be able to perform the same actions with its base
    
    class FishG : WaterAnimalG
    {
        public override void Swim()
        {
            Console.WriteLine("Swimming...");
        }
    }
}
