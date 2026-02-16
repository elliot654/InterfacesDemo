using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonsLibrary
{
    public abstract class RegularPolygon : IShape
    {
        public string Name { get; }
        public int Sides { get; }
        public double SideLength { get; }
        public RegularPolygon(string name, int sides, double sideLength)
        {
            Name = name;
            Sides = sides;
            SideLength = sideLength;
        }
        public double GetPerimeter()
        {
            return Sides * SideLength;
        }
        public abstract double GetArea();
    }
}
