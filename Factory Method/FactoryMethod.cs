using System;

// Step 1: Define the Product Interface
public interface IShape
{
    void Draw();
}

// Step 2: Create Concrete Products
public class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a Circle.");
    }
}

public class Rectangle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a Rectangle.");
    }
}

// Step 3: Create Static Factory Class
public static class ShapeFactory
{
    public static IShape CreateShape(string shapeType)
    {
        switch (shapeType.ToLower())
        {
            case "circle":
                return new Circle();
            case "rectangle":
                return new Rectangle();
            default:
                throw new ArgumentException("Invalid shape type.");
        }
    }
}
