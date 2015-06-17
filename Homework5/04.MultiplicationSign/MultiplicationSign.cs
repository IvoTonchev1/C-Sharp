using System;
    class MultiplicationSign
    {
        static void Main()
        {
            Console.WriteLine("Please enter numbers: ");
            double numOne = double.Parse(Console.ReadLine());
            double numTwo = double.Parse(Console.ReadLine());
            double numThree = double.Parse(Console.ReadLine());
            if (numOne == 0 || numTwo == 0 || numThree == 0)
            {
                Console.WriteLine("0");
            }
            else if (numOne > 0)
            {
                if(numTwo > 0)
                {
                    if(numThree > 0)
                    {
                        Console.WriteLine("+");
                    }
                    else if (numThree < 0)
                    {
                        Console.WriteLine("-");
                    }
                }
                else if (numTwo < 0)
                {
                    if(numThree > 0)
                    {
                        Console.WriteLine("-");
                    }
                    else if (numThree < 0)
                    {
                        Console.WriteLine("+");
                    }
                }
            }
            else if (numOne < 0)
            {
                 if(numTwo > 0)
                {
                    if(numThree > 0)
                    {
                        Console.WriteLine("-");
                    }
                    else if (numThree < 0)
                    {
                        Console.WriteLine("+");
                    }
                }
                else if (numTwo < 0)
                {
                    if(numThree > 0)
                    {
                        Console.WriteLine("+");
                    }
                    else if (numThree < 0)
                    {
                        Console.WriteLine("-");
                    }
                }
            }
        }
    }
