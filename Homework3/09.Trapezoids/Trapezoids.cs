using System;
    class Trapezoids
    {
        static void Main()
        {
            Console.WriteLine("Please enter trapezoid sides and height : ");
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("Area is : " + (((sideA+sideB)/2)*height));
        }
    }
