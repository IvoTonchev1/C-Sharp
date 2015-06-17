using System;
    class PrintDeckOfCards
    {
        static void Main()
        {
            string card;
            char suit;
            for (int j = 2; j < 15; j++)
            {
                switch (j)
                {
                    case 11:
                        card = "J";
                        break;
                    case 12:
                        card = "Q";
                        break;
                    case 13:
                        card = "K";
                        break;
                    case 14:
                        card = "A";
                        break;
                    default:
                        card = j.ToString();
                        break;
                }
                for (int i = 1; i < 5; i++)
                {
                    switch (i)
                    {
                        case 1:
                            Console.Write(card + '\u2660');
                            break;
                        case 2:
                            Console.Write(card + '\u2665');
                            break;
                        case 3:
                            Console.Write(card + '\u2666');
                            break;
                        case 4:
                            Console.WriteLine(card + '\u2663');
                            break;
                    }
                }
            }
        }
    }
