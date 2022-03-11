using System;
using System.Globalization;
using System.Threading;

namespace P129DateTimeGoTo
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime dateTime = new DateTime(11);

            //Console.WriteLine(dateTime.TimeOfDay);

            //Console.WriteLine(DateTime.Now.ToString("dddd"));

            //Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-EN");

            //Console.WriteLine(DateTime.Now.ToString("dddd"));

            //Console.WriteLine(DateTime.Now.AddDays(150).ToString("MMMM"));

            //int year = DateTime.Now.Year;
            //Console.WriteLine(year);

            //Console.WriteLine("Dogum Ilini Daxil Et");
            //int birthYear = int.Parse(Console.ReadLine());
            //Console.WriteLine("Yasini Daxil Et");
            //int age = int.Parse(Console.ReadLine());
            //int current = (DateTime.Now.Year - 1);
            //if (current - birthYear != age)
            //{
            //    Console.WriteLine("Duzgun Daxil Et:");
            //}

            //DateTime dateTime1 = new DateTime(1990, 12, 18);
            //DateTime dateTime2 = new DateTime(1990, 12, 17);

            //if (dateTime1 > dateTime2)
            //{
            //    Console.WriteLine(true);
            //}
            //Console.WriteLine(false);
            //Console.WriteLine(dateTime2.ToString("dddd/MMMM/yyyyy"));




            Console.WriteLine("Dogum Ilini Daxil Et");
            step1:
            int birthYear = int.Parse(Console.ReadLine());

            Console.WriteLine("Yasini Daxil Et");
            step2:
            int age = int.Parse(Console.ReadLine());

            int current = (DateTime.Now.Year - 1);
            if (birthYear < 1930)
            {
                Console.WriteLine("Dogum Ilini Duzgun Daxil Et");
                goto step1;
            }
            else if((current - birthYear) != age)
            {
                Console.WriteLine("Yasi Duzgun Daxil Et");
                goto step2;
            }
        }
    }
}
