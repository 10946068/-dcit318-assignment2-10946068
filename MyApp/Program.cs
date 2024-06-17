// Shape.cs
public abstract class Shape
{
    public abstract double GetArea();
}

// Circle.cs
public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }
}

// Rectangle.cs
public class Rectangle : Shape
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public override double GetArea()
    {
        return width * height;
    }
}

// Program.cs
class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(5);
        Console.WriteLine($"Circle area: {circle.GetArea()}"); // Output: Circle area: 78.53981633974483

        Rectangle rectangle = new Rectangle(10, 5);
        Console.WriteLine($"Rectangle area: {rectangle.GetArea()}"); // Output: Rectangle area: 50
    }
}