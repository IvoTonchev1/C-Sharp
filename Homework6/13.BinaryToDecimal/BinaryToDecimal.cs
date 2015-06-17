using System;
    class BinaryToDecimal
    {
        static void Main()
        {
            Console.Write("Please enter bunary number in 0 and 1 format: ");
            string binary = Console.ReadLine();
            long number = 0;
            int[] temp = new int[binary.Length];
            for (int j = 0; j < binary.Length; j++)
            {
                temp[j] = int.Parse(Convert.ToString(binary[j]));
            }
            Array.Reverse(temp);
            for (int i = 0; i < binary.Length; i++)
            {
                if (temp[i] == 0)
                {
                    continue;
                }
                number += (long)Math.Pow(2, i);
            }       
            Console.WriteLine("The decimal number is : " + number);
        }
    }
