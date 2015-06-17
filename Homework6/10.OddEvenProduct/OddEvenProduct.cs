using System;
    class OddEvenProduct
    {
        static void Main()
        {
            Console.WriteLine("Please enter number of integers: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter integers separated by space: ");
            string[] selection = Console.ReadLine().Split(' ');
            int productOdd = 1;
            int productEven = 1;
            for (int i = 0; i < number; i += 2)
            {
                productOdd *= int.Parse(selection[i]);
            }
            for (int j = 1; j < number; j += 2)
            {
                productEven *= int.Parse(selection[j]);
            }
            if (productOdd == productEven)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Product = " + productEven);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("odd_product = " + productOdd);
                Console.WriteLine("even_product = " + productEven);
            }
        }
    }