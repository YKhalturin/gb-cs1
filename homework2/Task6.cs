using System;
using System.Diagnostics;

namespace homework2
{
    partial class Homework2
    {
        /*
         * 6. *Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. 
         * Хорошим называется число, которое делится на сумму своих цифр. 
         * Реализовать подсчет времени выполнения программы, используя структуру DateTime.
         * 
         * Халтурин Юрий
         */

        static bool GoodNumber(int number)
        {
            int numberOrigin = number;
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return numberOrigin % sum == 0;
        }
        public static void Task6()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 1; i <= 10000000; i++)
            {
                if (GoodNumber(i))
                {
                    Console.WriteLine($"Хорошее число: {i}");
                }
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = $"{ts.Minutes} минут, {ts.Seconds} секунд, {ts.Milliseconds / 10} милисекнуд";
            Console.WriteLine("Затраченное время выполнения программы: " + elapsedTime);

        }
    }
}