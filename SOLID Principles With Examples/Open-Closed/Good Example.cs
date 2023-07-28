using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles_With_Examples.Open_Closed
{
    internal abstract class ShapeG
    {
        public abstract double GetArea();
    }
    internal class TriangleG : ShapeG
    {
        public double Length { get; set; }
        public double Height { get; set; }

        public override double GetArea()
        {
            return (Length * Height) / 2;
        }
    }

    class CircleG : ShapeG
    {
        public double Radius { get; set; }

        public override double GetArea()
        {
            return Radius * Radius * 3.14;
        }
    }


    // This class is open to evolution and close to modification 
    class AreaCalculationG
    {
        public double getAreaSum(ShapeG[] shapes)
        {
            double areaSum = 0;
            foreach (var item in shapes)
            {
                areaSum += item.GetArea();
            }
            return areaSum;
        }
    }
}
