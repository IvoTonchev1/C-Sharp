using System;
    class RectangleAreaPerimeter
    {
        static void Main()
        {
            double height;
            double width;
            Console.WriteLine("Please enter height and width in the next two lines:");
            height = double.Parse(Console.ReadLine());
            width = double.Parse(Console.ReadLine());
            Console.WriteLine("Perimeter is : " + ((2 * height) + (2 * width)));
            Console.WriteLine("Area is : " + (height * width));
        }
    }
