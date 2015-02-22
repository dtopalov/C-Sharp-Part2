

using System;

class TriangleArea
{
    static void Main()
    {
        Console.WriteLine("Choose a method for calculating triangle area: \n" +
                          "1. By side and an altitude to it\n" +
                          "2. By three sides\n" +
                          "3. By two sides and the angle between them");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1: Console.WriteLine("Enter side length: ");
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter altitude length: ");
                double altitude = double.Parse(Console.ReadLine());
                Console.WriteLine("The area is: {0}", TriangleAreaBySideAndAltitude(side, altitude));
                break;
            case 2: Console.WriteLine("Enter side a length: ");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter side b length: ");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter side c length: ");
                double c = double.Parse(Console.ReadLine());
                Console.WriteLine("Thea area is: {0}", TriangleAreaByThreeSides(a, b, c));
                break;
            case 3: Console.WriteLine("Enter side length: ");
                double firstSide = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter another side length: ");
                double secondSide = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the degrees of the angle between these sides: ");
                double angle = double.Parse(Console.ReadLine());
                Console.WriteLine("Thea area is: {0}", TriangleAreaByTwoSidesAndAngle(firstSide, secondSide, angle));
                break;
        }
        Main();
    }

    static double TriangleAreaBySideAndAltitude(double side, double altitude)
    {
        double area = side * altitude / 2;
        return area;
    }

    static double TriangleAreaByThreeSides(double a, double b, double c)
    {
        double p = (a + b + c)/2;
        double area = Math.Sqrt((p)*(p-a)*(p-b)*(p-c));
        return area;
    }

    static double TriangleAreaByTwoSidesAndAngle(double a, double b, double angle)
    {
        double area = (a*b*Math.Sin(angle*Math.PI/180))/2; //convert degrees to radians for Math.Sin
        return area;
    }
}
