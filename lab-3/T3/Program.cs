using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IRenderer vectorRenderer = new VectorRenderer();
            IRenderer rasterRenderer = new RasterRenderer();
            Shape circle = new Circle(rasterRenderer);
            Shape square = new Square(rasterRenderer);
            Shape triangle = new Triangle(vectorRenderer);
            circle.Draw();     
            square.Draw();     
            triangle.Draw();   
        }
    }
}
