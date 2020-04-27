using System;

namespace homework2
{
    /*
     * 7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);
     * б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
     * Халтурин Юрий
     * 
     */
    partial class Homework2
    {
        static void PrintAb(int a, int b)
        {
            if (a <= b)
            {
                Console.WriteLine(a);
                PrintAb(a + 1, b);
            }
        }

        static int SumAb(int a, int b)
        {
            if (a == b) return a;
            return a + SumAb(a + 1, b);
        }

        public static void Task7()
        {
            int a = 1;
            int b = 10;
            Console.WriteLine($"Распечатать рекурсивно числа от {a} до {b}");
            PrintAb(a, b);
            Console.WriteLine($"Сумма = {SumAb(a, b)}");
        }
    }
}