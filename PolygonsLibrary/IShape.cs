using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonsLibrary
{
    public interface IShape
    {
        string Name { get; }
        double GetPerimeter();
        double GetArea();
    }
}
