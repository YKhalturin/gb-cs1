using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace homework6
{
    /*
     * 2. Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
     * а) Сделайте меню с различными функциями и предоставьте пользователю выбор, для какой функции и на каком отрезке находить минимум.
     * б) Используйте массив (или список) делегатов, в котором хранятся различные функции.
     * в) *Переделайте функцию Load, чтобы она возвращала массив считанных значений. Пусть она возвращает минимум через параметр.
     * 
     * Юрий Халтурин
     */
    partial class Homework6
    {
        public delegate double Fun(double x);
        class Program
        {
            public static double F(double x)
            {
                return x * x - 50 * x + 10;
            }

            public static double F1(double x)
            {
                return x * x - 5;
            }

            public static double F2(double x)
            {
                return Math.Pow(x,3);
            }
            public static void SaveFunc(string fileName, Fun f, double a, double b, double h)
            {
                FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                double x = a;
                Console.WriteLine("| ----a----| ----b----| ----h----| --f(x)--");
                while (x <= b)
                {
                    Console.WriteLine("| {0,8:0.000} | {1,8:0.000} | {2,8:0.000} | {3,8:0.000} ", a, b, h, f(x));
                    bw.Write(f(x));
                    x += h;// x=x+h;
                }
                bw.Close();
                fs.Close();
            }
            public static double[] Load(string fileName, out double min)
            {
                FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                BinaryReader bw = new BinaryReader(fs);
                double[] arr = new double[fs.Length];
                min = Double.MaxValue;
                double d;
                for (int i = 0; i < fs.Length / sizeof(double); i++)
                {
                    // Считываем значение и переходим к следующему
                    d = bw.ReadDouble();
                    arr[i] = d;
                    if (d < min) min = d;
                }
                bw.Close();
                fs.Close();
                return arr;
            }
        }

        static int Menu()
        {
            int m;
            do
            {
                Console.WriteLine("1 - 'x * x - 50 * x + 10'");
                Console.WriteLine("2 - 'x * x - 5'");
                Console.WriteLine("3 - 'x ^ 3'");
                Console.WriteLine("0 - Exit");
                m = Convert.ToInt32(Console.ReadLine());
            }
            while (m < 0 && m > 3);
            return m;
        }

        public static void Task2()
        {
            Console.WriteLine("Выберите отрезок от a до b, на котором будет рассчитываться функция");
            Console.Write("Введите a:");
            double a = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.Write("Введите b:");
            double b = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.WriteLine("Выберите функцию, для которой будет рассчитаны значения");

            int menu = Menu();
            switch (menu)
            {
                case 1:
                    Program.SaveFunc("data.bin", Program.F, a, b, 0.5);
                    break;
                case 2:
                    Program.SaveFunc("data.bin", Program.F1, a, b, 0.5);
                    break;
                case 3:
                    Program.SaveFunc("data.bin", Program.F2, a, b, 0.5);
                    break;
                default:
                    Console.WriteLine("Bye!");
                    break;
            }
            Program.Load("data.bin", out double min);
            Console.WriteLine("Загрузили файл data.bin. Минимальное значение f(x) = " + min);

            Console.WriteLine("Сохраняем список всех делегатов функций");
            List<Fun> listOfDelegates = new List<Fun>
            {
                Program.F,
                Program.F1,
                Program.F2
            };
            int i = 1;
            foreach (var del in listOfDelegates)
            {
                Console.WriteLine($"Результат {i} функции f(5): {del.Invoke(5)}");
                i++;
            }
            Console.ReadKey();
        }
    }
}