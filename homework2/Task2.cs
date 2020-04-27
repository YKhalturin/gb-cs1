using System;

namespace homework2
{
    /*
    * 2. Написать метод подсчета количества цифр числа.
    * 
    * Юрий Халтурин
    */
    partial class Homework2
    {
        static int NumberCount(int number)
        {
            int count=0;
            while (number > 0)
            {
                number /= 10;
                count++;
            }
            return count;
        }

        static int NumberCount2(int number)
        {
            var str = number.ToString();
            return str.Length;
        }

        public static void Task2()
        {
            int number = 4324325;
            Console.WriteLine($"Количество цифр в числе {number} - {NumberCount(number)}");
        }
    }
}