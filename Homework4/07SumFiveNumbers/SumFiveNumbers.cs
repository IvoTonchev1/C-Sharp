
using System;
    class SumFiveNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter five numbers:");
            string[] sequence = Console.ReadLine().Split(' ');
            double numOne = double.Parse(sequence[0]);
            double numTwo = double.Parse(sequence[1]);
            double numThree = double.Parse(sequence[2]);
            double numFour = double.Parse(sequence[3]);
            double numFive = double.Parse(sequence[4]);
            Console.WriteLine("The sum is : " + (numOne + numTwo + numThree + numFour + numFive));
        }
    }
