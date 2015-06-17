using System;
    class Account
    {
        static void Main()
        {
            string firstName = "Tosho";
            string middleName = "Todorov";
            string lastName = "Toshev";
            decimal balance = 42335.15M;
            string bankName = "T-Bank";
            object iban = "BG80BNBG96611020345678";
            ulong cardOne = 2345789487647345;
            ulong cardTwo = 4685095300024719;
            ulong cardThree = 3677995510204783;
            Console.WriteLine("First Name: {0} \nMiddle Name: {1} \nLast Name: {2} \nBalance: {3} lv \nBank Name: {4} \nIBAN: {5}", firstName, middleName, lastName, balance, bankName, iban);
            Console.WriteLine("Credit Card 1 Number: {0} \nCredit Card 2 Number: {1} \nCredit Card 3 Number: {2}", cardOne, cardTwo, cardThree);
        }
    }
