using System;
    class BiggestOfThree
    {
        static void Main()
        {
            Console.WriteLine("Please enter three numbers: ");
            double numOne = double.Parse(Console.ReadLine());
            double numTwo = double.Parse(Console.ReadLine());
            double numThree = double.Parse(Console.ReadLine());
            if((numOne > numTwo) && (numOne > numThree))
            {   
                Console.WriteLine("The biggest number is: " + numOne);
            }
            else if ((numTwo > numThree) && (numTwo > numOne))
            {
                Console.WriteLine("The biggest number is: " + numTwo);
            }
            else if ((numThree > numOne) && (numThree > numTwo))
            {
                Console.WriteLine("The biggest number is: " + numThree);
            }
        }
    }
