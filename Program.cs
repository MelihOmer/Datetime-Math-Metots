using System;

namespace Datetime_Math_Metotlari
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            System.Console.WriteLine(DateTime.Now.DayOfWeek);
            System.Console.WriteLine(DateTime.Now.DayOfYear);

            System.Console.WriteLine(DateTime.Now.ToLongDateString());
            System.Console.WriteLine(DateTime.Now.ToShortDateString());
            System.Console.WriteLine(DateTime.Now.ToLongTimeString());
            System.Console.WriteLine(DateTime.Now.ToShortTimeString());

            System.Console.WriteLine(DateTime.Now.AddDays(2));
            System.Console.WriteLine(DateTime.Now.AddHours(3));
            System.Console.WriteLine(DateTime.Now.AddSeconds(30));
            System.Console.WriteLine(DateTime.Now.AddMonths(5));
            System.Console.WriteLine(DateTime.Now.AddYears(10));
            System.Console.WriteLine(DateTime.Now.AddMilliseconds(50));

            //Datetime Format
            System.Console.WriteLine(DateTime.Now.ToString("dd"));//13
            System.Console.WriteLine(DateTime.Now.ToString("ddd"));//Thu
            System.Console.WriteLine(DateTime.Now.ToString("dddd"));//Thurstday

            System.Console.WriteLine(DateTime.Now.ToString("MM"));//01
            System.Console.WriteLine(DateTime.Now.ToString("MMM"));//Oca
            System.Console.WriteLine(DateTime.Now.ToString("MMMM"));//Ocak

            System.Console.WriteLine(DateTime.Now.ToString("yy"));//22
            System.Console.WriteLine(DateTime.Now.ToString("yyyy"));//2022

            System.Console.WriteLine("*** Math Library ***");
            //Math Library
            System.Console.WriteLine(Math.Abs(-25));//25
            System.Console.WriteLine(Math.Sin(10));
            System.Console.WriteLine(Math.Cos(10));
            System.Console.WriteLine(Math.Tan(10));

            System.Console.WriteLine(Math.Ceiling(22.3));//23
            System.Console.WriteLine(Math.Round(22.3));//22
            System.Console.WriteLine(Math.Round(22.7));//23
            System.Console.WriteLine(Math.Round(22.5));
            System.Console.WriteLine(Math.Floor(22.7));//22

            System.Console.WriteLine(Math.Max(2,6));
            System.Console.WriteLine(Math.Min(2,6));

            System.Console.WriteLine("Pow :"+Math.Pow(3,4));//3^4 = 81.
            System.Console.WriteLine("Sqrt :"+Math.Sqrt(9));// Karekök Alır = 3.
            System.Console.WriteLine("Log :"+Math.Log(9));// 9 un e tabanındaki logoritmik karşılığını getirir.
            System.Console.WriteLine("Exp :"+Math.Exp(3));// e üzeri 3 ü verir.
            System.Console.WriteLine("Log10 :"+Math.Log10(10));// 10 sayısının logaritma 10 tabanındaki karşılığı verir.
            

        }
    }
}
