using PolygonsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    public class ShapeProcessor
    {
        public void PrintShapeDetails(IShape shape)
        {
            Console.WriteLine($"Shape: {shape.Name}");
            Console.WriteLine($"Perimeter: {shape.GetPerimeter():F2}");
            Console.WriteLine($"Area: {shape.GetArea():F2}");
            Console.WriteLine();
        }
    }
}
