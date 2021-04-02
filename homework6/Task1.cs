using System;

namespace homework6
{
    /*
     * 1. Изменить программу вывода функции так, чтобы можно было передавать функции типа double (double,double). 
     * Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
     * 
     * Юрий Халтурин
     */
    partial class Homework6
    {
        public delegate double Func(double x, double y);

        public static double ASin(double a, double x)
        {
            return a*Math.Sin(x);
        }
        public static double Ax2(double a, double x)
        {
            return a * Math.Pow(x,2);
        }

        public static void Table(Func F, double a, double x, double b)
        {
            Console.WriteLine("| ----A----| ----X----| ----Y----|");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} | {2,8:0.000} |", a, x, F(a, x));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }

        public static void Task1()
        {
            Console.WriteLine("Таблица функции y = a*sin(x):");
            Table(ASin, 6,-2, 2);
            Console.WriteLine("Таблица функции y = a*x^2:");
            Table(Ax2, 5, -2, 2);        }
    }
}