using System;
    class WeightOnMoon
    {
        static void Main()
        {
            double weight;
            Console.WriteLine("Please enter your weight:");
            weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Weight on the moon is : " + (0.17 * weight));
        }
    }
