using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace homework2
{
    /*
    * 3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
    * 
    * Юрий Халтурин
    */
    partial class Homework2
    {
        static bool OddNmber(int number)
        {
            return number % 2 != 0 ? true : false;
        }
        static int SumOddNumbers(List<int> numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                if (OddNmber(number))
                {
                    sum += number;
                }              
            }
            return sum;
        }

        public static void Task3()
        {
            Console.WriteLine("Введите положительные числа. Для завершения ввода введите 0");
            int number;
            List<int> numbers = new List<int>();
            do
            {
                Console.WriteLine("Введите число:");
                number = Convert.ToInt32(Console.ReadLine());
                numbers.Add(number);
            } while (number != 0);
            numbers.RemoveAt(numbers.Count-1);
            Console.WriteLine($"Сумма введенных нечетных чисел равна: {SumOddNumbers(numbers)}");            
        }
    }
}