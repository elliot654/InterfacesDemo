using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonsLibrary
{
    public class Circle : IShape
    {
        public string Name => "Circle";
        public double Radius { get; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
        public double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
