using System;
    class MatrixOfPalindromes
    {
        static void Main()
        {
            Console.Write("Enter number of rows: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Enter number of columns: ");
            int column = int.Parse(Console.ReadLine());
            string[,] result = new string[row, column];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    result[i, j] = ("" + Convert.ToChar('a' + i) + Convert.ToChar('a' + i + j) + Convert.ToChar('a' + i));
                    Console.Write(String.Format("{0} ", result[i,j]));
                }
                Console.WriteLine();
            }
        }
    }
