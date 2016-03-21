public abstract class Shape 
{
    
}

public class Rectangle : Shape 
{
    public Rectangle(double width, double height) 
    {
        Widht = width;
        Height = height;
    }
    
    public double Width { get; }
    public double Height { get; }
}

public class Circle : Shape 
{
    public Circle(double radius)
    {
        Radius = radius;
    }
    
    public double Radius { get; }
}

public class AreaCalculator
{
    public double SumArea(IEnumerable<Shape> shapes)
    {
        double sum;
        foreach (var shape in shapes)
        {
            if(shape is Circle)
                sum += CalculateArea((Circle)shape);
            else if (shape is Rectangle)
                sum += CalculateArea((Rectangle)shape);
            else
                throw new NotSupportedException();
        }
    }
    
    private double CalculateArea(Circle shape) { }
    
    private double CalculateArea(Rectangle shape) { }
    
    public void PrintSumArea(IEnumerable<Shape> shapes)
    {
        var sum = SumArea(shapes);
        Console.WriteLine($"The sum of the area is {sum}")
    }
}

public static class Program
{
    public static int Main()
    {
        var shapes = new []
            {
                new Rectangle(2, 3)
            };
        
        var calculator = new AreaCalculator();
        calculator.PrintSumArea(shapes);
    }
}