using System;
    class HelloWorld
    {
        static void Main()
        {
            string varOne = "Hello";
            string varTwo = "World";
            object varThree = varOne + " " + varTwo;
            string varFour = (string)varThree;
            Console.WriteLine(varThree);
            Console.WriteLine(varFour);
        }
    }