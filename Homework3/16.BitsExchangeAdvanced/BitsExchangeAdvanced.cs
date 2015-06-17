using System;
    class BitsExchangeAdvanced
    {
        static void Main()
        {
            Console.WriteLine("Please enter number and variables : ");
            uint number = uint.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            if ((Math.Max(p,q) + k - 1) > 31)
            {
                Console.WriteLine("Out of range");
            }
            else if ((Math.Min(p,q) + k -1) >= (Math.Max(p,q)))
            {
                Console.WriteLine("Overlapping");
            }
            else
            {
                for (int i = p; i <= p + k - 1; i++)
                {
                    uint mask = 1;
                    uint bitQ = (number & (mask << q)) >> q;
                    uint bitP = (number & (mask << i)) >> i;
                    number = number & ~(mask << i);
                    number = number & ~(mask << q);
                    number = number | (bitP << q);
                    number = number | (bitQ << i);
                    q++;
                }
                Console.WriteLine(number);
            }
        }
    }
