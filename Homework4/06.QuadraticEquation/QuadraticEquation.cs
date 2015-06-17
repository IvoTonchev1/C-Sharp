using System;
    class QuadraticEquation
    {
        static void Main()
        {
            Console.Write("Please enter first coefficient: ");
            double coefA = double.Parse(Console.ReadLine());
            Console.Write("Please enter second coefficient: ");
            double coefB = double.Parse(Console.ReadLine());
            Console.Write("Please enter third coefficient: ");
            double coefC = double.Parse(Console.ReadLine());
            double dis = Math.Pow(coefB, 2) - 4 * coefA * coefC;
            double x, x1, x2;
            if(dis > 0)
            {
                x1 = (-coefB + Math.Sqrt(dis)) / (2 * coefA);
                x2 = (-coefB - Math.Sqrt(dis)) / (2 * coefA);
                Console.WriteLine("The real roots are x1 = {0:F3} and x2 = {1:F3}", x1, x2);
            }
            else if (dis < 0)
            {
                Console.WriteLine("No real roots.");
            }
            else
            {
                x = (-coefB + Math.Sqrt(dis)) / (2 * coefA);
                Console.WriteLine("The real roots are x1 = x2 = {0:F3}", x);
            }
        }
    }