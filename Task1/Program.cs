using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    /**
     * Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). 
     * В результате вся информация выводится в одну строчку.
     *   а) используя склеивание;
     *   б) используя форматированный вывод;
     *   в) *используя вывод со знаком $.
     * 
     *  Халтури Юрий
     */
    class Program
    {
        static void Pause()
        {
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в прогрумму Анкета");
            Console.Write("Введите ваше имя:");
            string name = Console.ReadLine();
            Console.Write("Введите вашу Фамилию:");
            string surname = Console.ReadLine();
            Console.Write("Введите ваш возраст:");
            string age = Console.ReadLine();
            Console.Write("Введите ваш вес:");
            string weight = Console.ReadLine();

            Console.WriteLine("Склеивание - Имя: " + name + ", Фамилия: " + surname + ", Возраст: " + age + ", Вес: " + weight);
            Console.WriteLine("Форматированный вывод - Имя: {0}, Фамилия: {1}, Возраст: {2}, Вес: {3}", name, surname, age, weight);
            Console.WriteLine($"Используя$ - Имя: {name}, Фамилия: {surname}, Возраст: {age}, Вес: {weight}");
            Pause();


        }
    }
}
