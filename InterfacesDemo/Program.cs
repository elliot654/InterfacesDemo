using System;
using InterfacesDemo;
using PolygonsLibrary;
class Program
{
    public static void Main(String[] args)
    {
        List<IShape> shapes = new()
    {
        new Square(5),
        new Triangle(5),
        new Octagon(5),
        new Circle(5)
    };

        var processor = new ShapeProcessor();

        foreach (var shape in shapes)
        {
            processor.PrintShapeDetails(shape);
        }
    }
}
