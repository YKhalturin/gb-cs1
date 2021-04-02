using System;
using System.Linq;
using System.Security.AccessControl;
using System.Text.RegularExpressions;

namespace homework5
{
    /*
     * 1. Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка 
     * от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, 
     * при этом цифра не может быть первой:
     * а) без использования регулярных выражений;
     * б) с использованием регулярных выражений.
     * 
     * Халтурин Юрий
     */

    partial class Homework5
    {

        private static bool IsEnglishAndNumeric(string str)
        {
            char[] chr = str.ToCharArray();
            for (int i = 0; i < chr.Length; i++)
            {
                if (!(chr[i] >= 'A' && chr[i] <= 'z' || chr[i] >= '0' && chr[i] <= '9'))
                {
                    return false;
                }
            }
            return true;
        }

        static bool CheckLogin(string login)
        {
            Console.WriteLine("======== Проверяем обычными методами:");
            var result = true;
            var len = login.Length;
            if (len < 2 || len > 10)
            {
                Console.WriteLine($"Длина логина должна быть от 2 до 10 символов. Ваш логин содержит {len} символов");
                result = false;
            }
            if (char.IsNumber(login, 0)) 
            {
                Console.WriteLine("Цифра не может быть первой");
                result = false;
            }
            if (!IsEnglishAndNumeric(login))
            {
                Console.WriteLine("Логин должен содержать только буквы латинского алфавита или цифры");
                result = false;
            }
            if (result) Console.WriteLine("Проверка пройдена");
            return result;
        }

        static bool CheckLoginRegex(string login)
        {
            Console.WriteLine("======== Проверяем с использованием регулярных выражений");
            if (!Regex.IsMatch(login, "^[a-zA-Z]{1}[a-zA-Z0-9]{1,9}$"))
            {
                Console.WriteLine("Логин должен содержать только буквы латинского алфавита и цифры.\n" +
                                  "Длина логина должна быть от 2 до 10 символов.\n" +
                                  "Цифра не может быть первой");
                return false;
            }
            else
            {
                Console.WriteLine("Проверка пройдена");
                return true;
            }
            
        }

        public static void Task1()
        {
            int i = 0;
            string login;
            do
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Введите логин:");
                login = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Gray;
                CheckLogin(login);
            } while (!CheckLoginRegex(login));
        }
    }
}