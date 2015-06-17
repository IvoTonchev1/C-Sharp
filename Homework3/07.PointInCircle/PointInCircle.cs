using System;
    class PodoubleInCircle
    {
        static void Main()
        {
            Console.WriteLine("Please enter podouble coordinates : ");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            bool isInCircle = (((x*x) + (y*y)) <= (2*2));
            Console.WriteLine("Is the point in the circle : " + isInCircle);
        }
    }
