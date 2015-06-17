using System;
    class CatalanNumbers
    {
        static void Main()
        {
            Console.WriteLine("Please enter number n such that 1<n<100 :");
            double n = double.Parse(Console.ReadLine());
            double k = n + 1;
            double top = 2 * n;
            double sumTop = 1;
            double dividerK = 1;
            double bottom = 1;
            if ((n < 0) || (n >= 100))
            {
                Console.WriteLine("Invalid input!");
            }
            else if (n == 0)
            {
                Console.WriteLine("Catalan(n) = 1");
            }
            else if ((0 < n) || (n < 100))
            {
                for (int i = 1, j = 1; i <= top; i++, j++)
                {
                    sumTop *= i;
                    if (j > k)
                    {
                        continue;
                    }
                    dividerK *= j;
                }
                for (int l = 1; l <= n; l++)
                {
                    bottom *= l;
                }
                Console.WriteLine("Catalan(n) : " + ((sumTop) / (dividerK * bottom)));
            }
        }
    }
