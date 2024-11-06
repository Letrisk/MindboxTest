namespace Prototype
{
    using Geometry;

    internal class Program
    {
        static void Main(string[] args)
        {
            var shapes = new IShape[] { new Circle(15.8), new Triangle(7, 10.4, 15)  };

            foreach (var shape in shapes)
            {
                Console.WriteLine($"Площадь фигуры: {shape.GetArea()}");
            }
        }
    }
}
