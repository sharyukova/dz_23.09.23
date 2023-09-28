using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_23._09._23
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4.1) написать программу, которая переводит число от 1 до 365 в конкретную дату(месяц и число)");
            Console.WriteLine("Введите число от 1 до 365: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 1 || n > 365)
            {
                Console.WriteLine("Ошибка! Вы ввели число, не входящее в допустимый диапазон");
            }
            int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string[] namesformonths = { "января", "февраля", "марта", "апреля", "мая", "июня", "июля", "августа", "сентября", "октября", "ноября", "декабря" };
            int month = 0;
            int dayofmonth = 0;
            foreach (int daysincurrentmonth in days)
            {
                if (n <= daysincurrentmonth) 
                {
                    dayofmonth = n;
                    break;
                }
                else 
                {
                    n -= daysincurrentmonth;
                    month++;
                }
            }
            Console.WriteLine($"Найденная дата: {dayofmonth} {namesformonths[month]}");
            //
           
            
        }
    }
}
