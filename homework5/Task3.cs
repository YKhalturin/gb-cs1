using System;
using System.Linq;
using System.Security.AccessControl;

namespace homework5
{
    /*
     * 3. *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой. Регистр можно не учитывать:
     * а) с использованием методов C#;
     * б) *разработав собственный алгоритм.
     * Например: badc являются перестановкой abcd.
     * 
     * Халтурин Юрий
     */

    partial class Homework5
    {

        static string SortString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Sort(charArray);
            return new String(charArray);
        }

        static bool IsPermutation(string str1, string str2)
        {
            return SortString(str1).Equals(SortString(str2));
        }

        public static void Task3()
        {
            Console.Write("Введите строку 1:");
            var str1 = Console.ReadLine();
            Console.Write("Введите строку 2:");
            var str2 = Console.ReadLine();
            if (IsPermutation(str1, str2))
            {
                Console.WriteLine("Строки являются перестановками одна другой");
            }
            else
            {
                Console.WriteLine("Строки не являются перестановками одна другой");
            }
        }
    }
}