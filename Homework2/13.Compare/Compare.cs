using System;
    class Compare
    {
        static void Main()
        {
            double eps = 0.000001;

            Console.WriteLine("Please input the numbers you wish to compare on the next lines:");
            decimal varOne = decimal.Parse(Console.ReadLine());
            decimal varTwo = decimal.Parse(Console.ReadLine());

            double varThree = (double)Math.Abs(varOne - varTwo);

            bool check;

            if (varThree >= eps)
            {
                check = false;
                Console.WriteLine("Are the numbers equal? : {0}", check);
            }
            else
            {
                check = true;
                Console.WriteLine("Are the numbers equal? : {0}", check);
            }      
        }
    }
