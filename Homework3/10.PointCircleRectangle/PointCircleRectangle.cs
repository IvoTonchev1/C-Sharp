using System;
    class PointCircleRectangle
    {
        static void Main()
        {
            Console.WriteLine("Please enter point coordinates : ");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            bool isInCircle = ((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 1.5 * 1.5;
            bool isInRectangle = (x <= 5 && x >= -1) && (y >= -1 && y <= 1);
            if (isInCircle && !isInRectangle)
            {
                Console.WriteLine("The point is in the circle and outside the rectangle");
            }
            else
            {
                Console.WriteLine("The point is not in the designated area");
            }
        }
    }
