using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonsLibrary
{
    public class Octagon : RegularPolygon
    {
        public Octagon(double sideLength) : base("Octagon", 8, sideLength) { }

        public override double GetArea()
        {
            return SideLength * SideLength * (2 + 2 * Math.Sqrt(2));
        }
            
    }
}
