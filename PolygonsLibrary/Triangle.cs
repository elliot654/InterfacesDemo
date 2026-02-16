using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonsLibrary
{
    public class Triangle : RegularPolygon
    {
        public Triangle(int sideLength) : base("Triangle", 3, sideLength)
        {

        }
        public override double GetArea()
        {
            return Math.Sqrt(3) / 4 * (SideLength * SideLength);
        }
    }
}
