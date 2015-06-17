using System;
    class DecimalToHexadecimal
    {
        static void Main()
        {
            Console.Write("Please enter decimal number : ");
            long number = long.Parse(Console.ReadLine());
            string hex = "";
            if (number == 0)
            {
                hex = "0";
            }
            else
            {
                while (number > 0)
                {
                    long remain = number % 16;
                    number /= 16;
                    switch (remain)
                    {
                        case 10: 
                            hex = "A" + hex;
                            break;
                        case 11:
                            hex = "B" + hex;
                            break;
                        case 12: 
                            hex = "C" + hex; 
                            break;
                        case 13:
                            hex = "D" + hex; 
                            break;
                        case 14:
                            hex = "E" + hex;
                            break;
                        case 15:
                            hex = "F" + hex; 
                            break;
                        default:
                            hex = remain + hex;
                            break;
                    }
                }
            }
            Console.WriteLine("The hexadecimal number is : " + hex);
        }
    }
