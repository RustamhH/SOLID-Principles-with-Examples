using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles_With_Examples.Liskov_Substition
{
    internal abstract class AnimalB
    {
        public abstract void MakeNoise();
    }

    class DogB : AnimalB
    {
        public override void MakeNoise()
        {
            Console.WriteLine("Hav");
        }
    }


    // Derived class (Fish) cant interchange with its base (Animal) which is opposite to the Liskov principle
    class FishB : AnimalB
    {
        public override void MakeNoise()
        {
            throw new Exception("A fish can't make a noise under water");
        }
    }
}
