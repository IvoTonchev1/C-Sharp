using System;
    class CirclePerimeterArea
    {
        static void Main()
        {
            Console.Write("Please enter circle's radius: ");
            double radius = double.Parse(Console.ReadLine());
            double perimeter = 2 * radius * Math.PI;
            double area = Math.PI*Math.Pow(radius, 2);
            Console.WriteLine("Circle's perimeter: {0:F2}", perimeter);
            Console.WriteLine("Circle's area: {0:F2}", area);
        }
    }
