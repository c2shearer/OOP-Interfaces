using Interfaces;
using Interfaces.Shapes;

Square square = new Square(10, 20, Colours.RED);
Triangle triangle = new Triangle(10, 20, Colours.BLACK);

List<IShape> shapes = new List<IShape>()
{
    square, triangle
};

foreach (var shape in shapes)
{
    Console.WriteLine(shape);
}