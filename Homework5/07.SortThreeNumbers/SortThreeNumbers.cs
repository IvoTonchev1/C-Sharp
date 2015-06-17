using System;
    class SortThreeNumbers
    {
        static void Main()
        {
            Console.WriteLine("Please enter three numbers: ");
            double numOne = double.Parse(Console.ReadLine());
            double numTwo = double.Parse(Console.ReadLine());
            double numThree = double.Parse(Console.ReadLine());
            if((numOne > numTwo) && (numOne > numThree))
            {
                if(numTwo > numThree)
                {
                    Console.WriteLine(numOne + " " + numTwo + " " + numThree);
                }
                else
                {
                    Console.WriteLine(numOne + " " + numThree + " " + numTwo);
                }
            }
            else if((numTwo > numOne) && (numTwo > numThree))
            {
                if(numOne > numThree)
                {
                    Console.WriteLine(numTwo + " " + numOne + " " + numThree);
                }
                else
                {
                    Console.WriteLine(numTwo + " " + numThree + " " + numOne);
                }
            }
            else if((numThree > numOne) && (numThree > numTwo))
            {
                if(numOne > numTwo)
                {
                    Console.WriteLine(numThree + " " + numOne + " " + numTwo);
                }
                else
                {
                    Console.WriteLine(numThree + " " + numTwo + " " + numOne);
                }
            }
        }
    }