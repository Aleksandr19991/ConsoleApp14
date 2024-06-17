using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp14;

namespace ConsoleApp14
{
    public static class SpesialOffers
    {


        public static string ReadFromConsoleClientName()
        {
            Console.WriteLine("Укажите Ваше Имя и Фамилию?");
            string clientName = Console.ReadLine();

            return clientName;
        }
        public static int ReadFromConsoleAge()
        {
            Console.WriteLine("Сколько Вам полных лет?");
            string h = Console.ReadLine();
            int age = Convert.ToInt32(h);

            return age;
        }
        public static int ReadFromConsoleService()
        {
            Console.WriteLine("Укажите количество используемых услуг?");
            string l = Console.ReadLine();
            int service = Convert.ToInt32(l);

            return service;
        }
        public static int ReadFromConsoleSum()
        {
            Console.WriteLine("Укажите сумму средств на счете?");
            string p = Console.ReadLine();
            int sum = Convert.ToInt32(p);

            return sum;
        }


        public static int CheckingValue(int age, int service, int sum)
        {
            int temp = 0;
            bool share = service >= 3 || sum > 400000 || age > 60;
            if (share == true) temp = 1;
            else temp = 0;

            return temp;

        }
        public static void WriteResult(string clientName, int temp)
        {

            if (clientName == "Иван Иванов")
            {
                if (temp == 1)
                { Console.WriteLine("Вам доступны акционные предложения!"); }

                else if (temp == 0)
                { Console.WriteLine("Скидка для Вас не действует"); }

            }
            else if (clientName == "Петр Петров")
            {
                if (temp == 1)
                { Console.WriteLine("Вам доступны акционные предложения!"); }
                else if (temp == 0)
                { Console.WriteLine("Скидка для Вас не действует"); }

            }

            else if (clientName == "Сергей Сергеев")
            {

                if (temp == 1)
                { Console.WriteLine("Вам доступны акционные предложения!"); }
                else if (temp == 0)
                { Console.WriteLine("Скидка для Вас не действует"); }

            }
            else { Console.WriteLine("Клиент не найден"); }


        }
    }


    public static class BankDeposit
    {
        public static int ReadFromConsoleAmount()
        {
            Console.WriteLine("Укажите сумму вклада?");
            string s = Console.ReadLine();
            int amount = Convert.ToInt32(s);

            return amount;
        }
        public static int ReadFromConsoleYear()
        {
            Console.WriteLine("Укажите на какой срок (в годах) делаете вклад?");
            string h = Console.ReadLine();
            int year = Convert.ToInt32(h);

            return year;
        }
        public static int ReadFromConsolePercent()
        {
            Console.WriteLine("Укажите процент по вкладу?");
            string l = Console.ReadLine();
            int percent = Convert.ToInt32(l);

            return percent;
        }

        public static int CoutingSaving(int amount, int year, int percent)
        {

            int revenue = (amount * percent * year / year) / 100 + amount;
            int temp = revenue;

            for (int j = year; j > 1; j--)
            {
                temp = temp + 110;
            }

            return temp;

        }

        public static void WriteResult(int temp)
        {
            Console.WriteLine($"Ваш размер накоплений составит {temp}");
        }

    }


    public static class CoutingBanknotes
    {

        public static int ReadFromConsole()
        {
            Console.WriteLine("Укажите сумму");
            string s = Console.ReadLine();
            int n = Convert.ToInt32(s);
            return n;

        }

        public static int CountResult(int n)
        {
            int a = 1000;
            int b = 500;
            int c = 100;
            int temp = 0;


            while (n != 0)
            {
                if (n >= a)
                {
                    n = n - a; temp = temp + 1;
                }
                if (n >= b && n < a)
                {
                    n = n - b; temp = temp + 1;
                }
                if (n >= c && n < b)
                {
                    n = n - c; temp = temp + 1;
                }
            }

            return temp;

        }

        public static void WriteResult(int temp)
        {

            Console.WriteLine($"Вам нужно {temp} банкнот");

        }
    }


}
