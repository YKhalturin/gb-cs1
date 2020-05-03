using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
    /*
     * 2. а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). 
     * Требуется подсчитать сумму всех нечетных положительных чисел. 
     * Сами числа и сумму вывести на экран, используя tryParse;
     * 
     * Халтурин Юрий
     */
    partial class Homework3
    {
        static bool OddNmber(int number)
        {
            return number % 2 != 0;
        }
        static int SumOddNumbers(List<int> numbers, out string positiveNumbers)
        {
            int sum = 0;
            positiveNumbers = "";
            foreach (var number in numbers)
            {
                if (OddNmber(number) && number > 0)
                {
                    sum += number;
                    positiveNumbers += $"{number} ";
                }
            }
            return sum;
        }

        static int GetValue(string message)
        {
            int x;
            string s;
            bool flag;      
            do
            {
                Console.WriteLine(message);
                s = Console.ReadLine();
                flag = int.TryParse(s, out x);
                if (!flag) Console.WriteLine("Введено не целое число, повторите попытку. 0 - чтобы заввершить");
        
            }
            while (!flag);
            return x;
        }


        public static void Task2()
        {
            Console.WriteLine("Введите целые числа. Для завершения ввода введите 0");
            int number;
            List<int> numbers = new List<int>();
            do
            {
                number = GetValue("Введите число:");
                numbers.Add(number);
            } while (number != 0);
            numbers.RemoveAt(numbers.Count - 1);
            var sum = SumOddNumbers(numbers, out string positiveNumbers);
            Console.WriteLine($"Нечетные положительные числа: {positiveNumbers}");
            Console.WriteLine($"Сумма введенных нечетных положительных чисел равна: {sum}");
        }
    }
}
