using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles_With_Examples.Open_Closed
{
    internal class ShapeB
    {
        public double Area { get; set; }
    }
    internal class TriangleB:ShapeB
    {
        public double Length { get; set; }
        public double Height { get; set; }
    }

    class CircleB:ShapeB
    {
        public double Radius { get; set; }
    }

    // Class is open to changes : which is bad , because every time a new shape is added , there is going to be extra
    // if-s in the code

    class AreaCalculationB
    {
        public double getAreaSum(ShapeB[] shapes)
        {
            double areaSum = 0;  
            foreach (var item in shapes)
            {
                if(item is TriangleB tr)
                {
                    tr.Area = (tr.Length * tr.Height) / 2;
                    areaSum+=tr.Area;
                }
                else if (item is CircleB circle)
                {
                    circle.Area = circle.Radius*circle.Radius*3.14;
                    areaSum += circle.Area;
                }
            }
            return areaSum;
        }
    }
}
