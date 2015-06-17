using System;
    class PlayWith
    {
        static void Main()
        {
            Console.WriteLine("Please choose a type \n 1 --> int \n 2 --> double \n 3 --> string");
            int type = int.Parse(Console.ReadLine());
            switch (type)
            {
                case 1:
                    Console.Write("Please enter an integer: ");
                    int number = int.Parse(Console.ReadLine());
                    Console.WriteLine(number + 1);
                    break;
                case 2:
                    Console.WriteLine("Please enter double: ");
                    double numberD = double.Parse(Console.ReadLine());
                    Console.WriteLine(numberD + 1);
                    break;
                case 3:
                    Console.WriteLine("Please enter string: ");
                    string newString = Console.ReadLine();
                    Console.WriteLine(newString + '*');
                    break;
                default:
                    Console.WriteLine("Incorrect choice!");
                    break;
            }
        }
    }
