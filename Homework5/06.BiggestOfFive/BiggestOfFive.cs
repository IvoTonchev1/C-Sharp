using System;
    class BiggestOfFive
    {
        static void Main()
        {
            Console.WriteLine("Please enter five numbers: ");
            double numOne = double.Parse(Console.ReadLine());
            double numTwo = double.Parse(Console.ReadLine());
            double numThree = double.Parse(Console.ReadLine());
            double numFour = double.Parse(Console.ReadLine());
            double numFive = double.Parse(Console.ReadLine());
            if ((numOne > numTwo) && (numOne > numThree) && (numOne > numFour) && (numOne > numFive))
            {
                Console.WriteLine("The biggest number is: " + numOne);
            }
            else if ((numTwo > numThree) && (numTwo > numOne) && (numTwo > numFour) && (numTwo > numFive))
            {
                Console.WriteLine("The biggest number is: " + numTwo);
            }
            else if ((numThree > numOne) && (numThree > numTwo) && (numThree > numFour) && (numThree > numFive))
            {
                Console.WriteLine("The biggest number is: " + numThree);
            }
            else if ((numFour > numOne) && (numFour > numTwo) && (numFour > numThree) && (numFour > numFive))
            {
                Console.WriteLine("The biggest number is: " + numFour);
            }
            else if ((numFive > numOne) && (numFive > numTwo) && (numFive > numThree) && (numFive > numFour))
            {
                Console.WriteLine("The biggest number is: " + numFive);
            }
        }
    }
