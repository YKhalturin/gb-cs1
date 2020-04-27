using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    /* а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
     * б) Сделать задание, только вывод организуйте в центре экрана
     * в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y)
     * 
     * Халтурин Юрий
     */
    class Program
    {
        public static void Print(string message, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(message);
        }

        static void Main(string[] args)
        {
            string name = "Юрий";
            string surname = "Халтурин";
            string city = "Краснодар";

            string message = $"Имя: {name}, Фамилия:{surname}, город: {city}";
            int messageLength = message.Length;
            // Выводим текст в центре экрана
            int x = (Console.WindowWidth / 2) - (messageLength / 2);
            int y = Console.WindowHeight / 2;
            Print(message, x, y);
            Console.ReadKey();
        }
    }
}
