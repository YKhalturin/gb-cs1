using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    /*
     * 4. Написать программу обмена значениями двух переменных.
     * а) с использованием третьей переменной;
     * б) *без использования третьей переменной
     * 
     * Юрий Халтурин
     */
    class Program
    {
        static void Main(string[] args)
        {
            var a = "a";
            var b = "b";
            var temp = "";
            Console.WriteLine($"Иходные данные: a={a}, b={b}");
            Console.WriteLine("Меняем значения двух переменных a И b...");
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"Результат: a={a}, b={b}");
            Console.ReadKey();
        }
    }
}
