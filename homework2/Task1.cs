using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    /*
    * 1. Написать метод, возвращающий минимальное из трех чисел.
    * Юрий Халтурин
    */
    partial class Homework2
    {

        static int Min(int a, int b)
        {
            return a < b ? a : b;
        }
        static int GetMin3Numbers(int a, int b, int c)
        {
            return Min(a, Min(b, c));
        }

        public static void Task1()
        {
            int a = 23;
            int b = 22;
            int c = 54;

            Console.WriteLine($"Минимальное из 3х чисел {a}, {b}, {c} : {GetMin3Numbers(a, b, c)}");
        }

    }
}
