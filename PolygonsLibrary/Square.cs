using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonsLibrary
{
    public class Square : RegularPolygon
    {
        public Square(double sideLength) : base("Square", 4, sideLength)
        {

        }
        public override double GetArea()
        {
            return SideLength * SideLength;
        }
    }
}
