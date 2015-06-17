using System;
    class CompanyInfo
    {
        static void Main()
        {
            Console.Write("Company Name: ");
            string comName = Console.ReadLine();
            Console.Write("Company address: ");
            string comAddress = Console.ReadLine();
            Console.Write("Phone Number: ");
            string phoneNum = Console.ReadLine();
            Console.Write("Fax Number: ");
            string faxNum = Console.ReadLine();
            Console.Write("Company WebSite: ");
            string webSite = Console.ReadLine();
            Console.Write("Manager's first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Manager's last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Manager's age: ");
            string age = Console.ReadLine();
            Console.Write("Manager's phone number: ");
            string manPhone = Console.ReadLine();
            Console.WriteLine(comName);
            Console.WriteLine("Address: " + comAddress);
            Console.WriteLine("Tel. {0: +### ### ## ## ##}", phoneNum);
            Console.WriteLine("Fax: {0: ## ### ## ##}", faxNum);
            Console.WriteLine("Web Site: " + webSite);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3: +### # ### ###})", firstName, lastName, age, manPhone); 
        }
    }
