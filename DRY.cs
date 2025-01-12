using System;

class ShapeCalculator
{
    // Method to calculate the area of a rectangle
    public static double CalculateRectangleArea(double length, double width)
    {
        return length * width;
    }

    // Method to calculate the perimeter of a rectangle
    public static double CalculateRectanglePerimeter(double length, double width)
    {
        return 2 * (length + width);
    }

    // Method to calculate the area of a circle
    public static double CalculateCircleArea(double radius)
    {
        return Math.PI * radius * radius;
    }

    // Method to calculate the circumference of a circle
    public static double CalculateCircleCircumference(double radius)
    {
        return 2 * Math.PI * radius;
    }

    // Generic method to display results
    public static void DisplayResult(string shape, double area, double perimeter)
    {
        Console.WriteLine($"{shape} Area: {area}");
        Console.WriteLine($"{shape} Perimeter/Circumference: {perimeter}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Rectangle
        double rectangleLength = 5;
        double rectangleWidth = 10;
        double rectangleArea = ShapeCalculator.CalculateRectangleArea(rectangleLength, rectangleWidth);
        double rectanglePerimeter = ShapeCalculator.CalculateRectanglePerimeter(rectangleLength, rectangleWidth);
        ShapeCalculator.DisplayResult("Rectangle", rectangleArea, rectanglePerimeter);

        // Circle
        double circleRadius = 7;
        double circleArea = ShapeCalculator.CalculateCircleArea(circleRadius);
        double circleCircumference = ShapeCalculator.CalculateCircleCircumference(circleRadius);
        ShapeCalculator.DisplayResult("Circle", circleArea, circleCircumference);
    }
}
