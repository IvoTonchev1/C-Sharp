using System;
    class FormattingNumbers
    {
        static void Main()
        {
            Console.Write("Enter integer >= 0 and <= 500 : ");
            int numOne = int.Parse(Console.ReadLine());
            if(numOne < 0 || numOne > 500)
            {
                Console.WriteLine("Invalid number");
            }
            else
            {
                Console.Write("Enter first floating-point number : ");
                double numTwo = double.Parse(Console.ReadLine());
                Console.Write("Enter second floating-point number : ");
                double numThree = double.Parse(Console.ReadLine());
                string binary = Convert.ToString(numOne,2).PadLeft(10, '0');
                Console.WriteLine("|{0,-10:X}|{1}|{2,10:F2}|{3,-10:F3}|", numOne, binary, numTwo, numThree);
            }        
        }
    }
