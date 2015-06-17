using System;
using System.Collections.Generic;
using System.Linq;
    class RandomizeNumbers
    {
        static void Main()
        {
            Console.Write("Please enter number: ");
            int number = int.Parse(Console.ReadLine());
            int[] numbers = new int[number];
            Random rnd = new Random();
            if (number < 1)
	        {
		        Console.WriteLine("Invalid input.");
	        }
            else
	        {
                for (int i = 0; i < number; i++)
                {
                    numbers[i] = i + 1;
                }            
	        }
            foreach (int index in numbers )
            {
                int randomNum = rnd.Next(0, number);
                int temp = numbers[randomNum];
                numbers[randomNum] = numbers[0];
                numbers[0] = temp;
            }
            Console.WriteLine(String.Join(" ", numbers));
        }     
    }
