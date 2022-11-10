using System;
namespace PhoneBook
{
    internal class Program

    {
        public enum TypeOfNumber
        {
            mobile,
            work,
            official
        }
        static void Main(string[] args)
        {
            PhoneBook[] newPhoneBook =
            {
                new PhoneBook("Alex", "0954753402", TypeOfNumber.mobile),
                new PhoneBook("Dmytro", "0963459872", TypeOfNumber.mobile),
                new PhoneBook("Arthur", "0957652349", TypeOfNumber.mobile),
                new PhoneBook("Oleg", "1111111111", TypeOfNumber.work),
                new PhoneBook("Stanislav", "0954753678", TypeOfNumber.mobile),
                new PhoneBook("Anastasia", "0665663402", TypeOfNumber.official),
                new PhoneBook("Roman", "0999999999", TypeOfNumber.work),
                new PhoneBook("Kostyantin", "2423242332", TypeOfNumber.mobile),
            };
            while (true)
            {
                Console.WriteLine("================");
                Console.WriteLine("If you want to search by name of owner - press 1");
                Console.WriteLine("If you want to search by number of owner - press 2");
                Console.WriteLine("If you wany to search by number type of number - press 3 ");
                Console.WriteLine("================");
                string operationNumber = Console.ReadLine();

                Console.WriteLine("Enter the value: ");
                string stringToFind = Console.ReadLine();

                bool valueIsCorrect = true;
                foreach(PhoneBook person in newPhoneBook)
                {
                    switch (operationNumber)
                    {
                        case "1":
                            if (person.FindByName(stringToFind))
                            {
                                Console.WriteLine(person.GetInfo());
                                valueIsCorrect = true;
                            }
                            break;
                        case "2":
                            if (person.FindByNumber(stringToFind))
                            {
                                Console.WriteLine(person.GetInfo());
                                valueIsCorrect= true;
                            }
                            break;
                        case "3":
                            if (person.FindByType((TypeOfNumber)Enum.Parse(typeof(TypeOfNumber), stringToFind)))
                            {
                                Console.WriteLine(person.GetInfo());
                                valueIsCorrect=true;
                            }
                            break;
                    }
                }
                if (!valueIsCorrect)
                {
                    Console.WriteLine("Unexpected result");
                }
            }
        }
        public struct PhoneBook
        {
            private string personName;
            private string phoneNumber;
            private TypeOfNumber phoneTypeOfNumber;
            public PhoneBook(string personName, string  phoneNumber, TypeOfNumber phoneNumberType)
            {
                this.personName = personName;   
                this.phoneNumber = phoneNumber;
                this.phoneTypeOfNumber = phoneNumberType;
            }
            public string GetInfo()
            {
                return $"Abonent: {personName}, phone type: {phoneTypeOfNumber} - {phoneNumber}";
            }
            public bool FindByName(string stringToFind)
            {
                return personName.ToLower().Contains(stringToFind.ToLower());
            }

            public bool FindByNumber(string stringToFind)
            {
                return phoneNumber.ToLower().Contains(stringToFind.ToLower());
            }

            public bool FindByType(TypeOfNumber numberType)
            {
                return phoneTypeOfNumber == numberType;
            }
        }
        
    }
}