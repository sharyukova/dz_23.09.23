using System;
using System.Security.Cryptography;


namespace laboratornaya4
{
    internal class Program
    {
        enum DayOfWeek
        {
            Понедельник = 1,
            Вторник,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскресенье
        }
        static void Main(string[] args)
        {
            // 1. последовательнсть чисел. выяснить, является ли упорядоченной по возрастанию и с какого момента нарушается эта последовательность
            int[] seq = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            bool proverka = true;
            int index = -1;

            for (int i = 1; i < seq.Length; i++)
            {
                if (seq[i] <= seq[i - 1])
                {
                    proverka = false;
                    index = i;
                    break;
                }
            }

            if (proverka)
            {
                Console.WriteLine("1. Последовательность упорядочена по возрастанию");
            }
            else
            {
                Console.WriteLine($"1. Порядковый номер первого числа, нарушающего последовательность: {index}");
            }
            // 2. 
            Console.WriteLine("Введите номер от 6 до 14 (включительно)");
            int k = int.Parse(Console.ReadLine()); // Заданный номер карты

            try
            {
                string cardname;

                if (k == 11)
                {
                    cardname = "валет";
                }
                else if (k == 12)
                {
                    cardname = "дама";
                }
                else if (k == 13)
                {
                    cardname = "король";
                }
                else if (k == 14)
                {
                    cardname = "туз";
                }
                else if (k >= 6 && k <= 10)
                {
                    cardname = k.ToString();
                }
                else
                {
                    throw new Exception("Некорректный номер карты");
                }

                Console.WriteLine($"Достоинство карты с номером {k}: {cardname}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Конец программы");
            }
            // 3
            Console.WriteLine("3. Введите любое из имеющихся выражений: Jabroni, school counselor, programmer, Bike gang member, politician, Rapper - ");
            string s1 = (Console.ReadLine()).ToLower();
            switch (s1.ToLower())
            {
                case "jabroni": Console.WriteLine("Patron Tequila"); break;
                case "school counselor": Console.WriteLine("Anything with Alcohol"); break;
                case "programmer": Console.WriteLine("Hipster Craft Beer"); break;
                case "bike gang member": Console.WriteLine("Moonshine"); break;
                case "politician": Console.WriteLine("Your tax dollars"); break;
                case "rapper": Console.WriteLine("Crystal"); break;
                default: Console.WriteLine("Beer"); break;
            }
            // 4. задачка про дни недели
            Console.WriteLine("4. Составить программу, которая в зависимости от порядкового номера дня недели (1, 2,\r\n...,7) выводит на экран его название (понедельник, вторник, ..., воскресенье).\r\nИспользовать enum.");
            Console.WriteLine("Введите порядковый номер недели (от 1 до 7): ");
            int Number = int.Parse(Console.ReadLine());
            try
            {
                if (Number < 1 || Number > 7)
                {
                    throw new Exception("Некорректный порядковый номер дня недели");
                }

                DayOfWeek day = (DayOfWeek)Number;

                Console.WriteLine($"День недели с порядковым номером {Number}: {day}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Конец программы");
            }
            // 5. 
            Console.WriteLine("При помощи foreach обойти весь массив. При встрече элемента\r\n\"Hello Kitty\" или \"Barbie doll\" необходимо положить их в “сумку”, т.е. прибавить к\r\nрезультату. Вывести на экран сколько кукол в “сумке”.");
            string[] toys = { "Hello Kitty", "Barbie doll", "Monster High", "Winx", "Hello Kitty" };
            int Count = 0;

            foreach (string toy in toys)
            {
                if (toy == "Hello Kitty" || toy == "Barbie doll")
                {
                    Count++;
                }
            }

            Console.WriteLine($"В сумке {Count} игрушек");

        }
    }
}
