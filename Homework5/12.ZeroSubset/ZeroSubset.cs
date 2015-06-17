using System;
    class ZeroSubset
    {
        static void Main()
        {
            int sum;
            bool found = false;
            int[] number = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Please enter integer " + (i + 1) + " : ");
                number[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (int begin = 0; begin < 5; begin++)
            {
                sum = 0;
                for (int finish = begin; finish < 5; finish++)
                {
                    sum = sum + number[finish];
                    if (sum == 0)
                    {
                        found = true;       
                        Console.WriteLine();
                        for (int i = begin; i < finish; i++)
                        {
                            Console.Write("{0} + ", number[i]);
                        }
                        Console.Write(number[finish]);
                        Console.WriteLine(" = 0");
                    }
                }
            }
            if (found == false)
            {
                Console.WriteLine();
                Console.WriteLine("No zero subset.");
            }
        }
    }
