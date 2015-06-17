using System;
    class CalculateProblemFive
    {
        static void Main()
        {
            Console.WriteLine("Please enter two integers :");
            double numOne = double.Parse(Console.ReadLine());
            double numTwo = double.Parse(Console.ReadLine());
            double sum = 1;
            double temp = 1;
            for (int i = 1; i <= numOne; i++)
			{
                temp *= i;
                sum += temp / (Math.Pow(numTwo, i));
			}
            Console.WriteLine("{0:F5}", sum);
        }
    }
