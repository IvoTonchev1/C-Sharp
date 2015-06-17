using System;
    class SortingNumbers
    {
        static void Main()
        {
            Console.Write("Please enter number of numbers: ");
            int number = int.Parse(Console.ReadLine());
            int[] unsorted = new int[number];
            for (int i = 0; i < number; i++)
            {
                unsorted[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (int j = 0; j < unsorted.Length - 1; j++)
            {
                for (int k = j + 1; k < unsorted.Length; k++)
                {             
                    if (unsorted[j] > unsorted[k])
                    {
                        int temp = unsorted[j];
                        unsorted[j] = unsorted[k];
                        unsorted[k] = temp;
                    }
                }
            }
            Console.WriteLine(String.Join("\n", unsorted));
        }
    }
