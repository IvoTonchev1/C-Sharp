using System;
    class LongestAreaInArray
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string[] sequence = new string[number];
            for (int i = 0; i < sequence.Length; i++)
            {
                sequence[i] = Console.ReadLine();
            }
            int length = 0;
            string result = null;
            for (int j = 0; j < sequence.Length; j++)
            {
                int count = 0;
                for (int k = j; k < sequence.Length; k++)
                {
                    if (sequence[j] == sequence[k])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (length < count)
                {
                    length = count;
                    result = sequence[j];
                }
            }
            Console.WriteLine();
            Console.WriteLine(length);
            for (int l = 0; l < length; l++)
            {
                Console.WriteLine(result);
            }
        }
    }
