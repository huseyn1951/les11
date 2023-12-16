using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            //task 4 and 5
            /*ChechReverse();
            CheckContains();*/

            //bank app
            /*CheckPin();
            WorkWithBalance();*/

            //task6
            /*AddContact();*/

        }


        public static string ChechReverse()
        {
            Console.WriteLine("cevirmek istediyiniz sozu daxil edin:  ");
            string word = Console.ReadLine();

            char[] chars = word.ToCharArray();
            Array.Reverse(chars);

            string reversedWord = new string(chars);
            Console.WriteLine($"reverse olunmush soz:  {reversedWord} ");


            if (word == reversedWord)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            return reversedWord;

        }

        public static void CheckContains()
        {
            Console.WriteLine("cumleni daxil edin: ");
            string mainString = Console.ReadLine();
            Console.WriteLine("yoxlamag istediyiniz sozu daxil edin: ");
            string word = Console.ReadLine();

            if (mainString.Contains(word))
            {
                Console.WriteLine("uygundur");
            }
            else
            {
                Console.WriteLine("uygun deyil");
            }
        }

        public static void CheckPin()
        {
            string PIN = "1312";
            Console.WriteLine("HuseynBanka xosh gelmisiniz");
            Console.ReadLine();
            Console.WriteLine("zehmet olmasa pin kodu daxil edin: ");

            string input = Console.ReadLine();

            if (input == PIN)
            {
                Console.WriteLine("pin kod duzdu");
            }

            else
            {
                Console.WriteLine("pin kod yalnisdir");
            }

        }

        public static void WorkWithBalance()
        {
            Console.WriteLine(" istediyiniz balans daxil edin: ");
            string balanceInput = Console.ReadLine();
            int balance = int.Parse(balanceInput);
            Console.WriteLine($"balansiniz: {balance}");

            Console.WriteLine("cixartmag istediyiniz meblegi daxil edin:");
            string cashInput = Console.ReadLine();
            int cash = int.Parse(cashInput);

            if (balance >= cash)
            {
                int diff = balance - cash;
                Console.WriteLine("pulunuzu goturun");
                Console.ReadLine();
                Console.WriteLine($"balansinizda qalig mebleg {diff}");
            }
            else
            {
                Console.WriteLine($"balansinizda kifayet qeder vesait yoxdur.balansinizda olan mebleg: {balance}");
            }

        }

        public static void AddContact()
        {
            
            Console.WriteLine("add new contact: ");
            Console.WriteLine("add name");
            string name = Console.ReadLine();

            Console.WriteLine("add surname");
            string surname = Console.ReadLine();

            Console.WriteLine("add number");
            string number = Console.ReadLine();

            string[] contacts = { name, surname, number };

            Console.WriteLine($"concatc: {name} {surname}  {number} ");

            Console.WriteLine("search  contact: ");
            string searchedContactInput = Console.ReadLine();

            if (name.Contains(searchedContactInput) || surname.Contains(searchedContactInput) || number.Contains(searchedContactInput))
            {
                Console.WriteLine($"concatc: {name} {surname}  {number} ");
            }
            else
            {
                Console.WriteLine("not found");
            }

        }

}
}
