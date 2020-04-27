using System;

namespace homework2
{
    partial class Homework2
    {
        /* 4. Реализовать метод проверки логина и пароля. На вход подается логин и пароль. 
         * На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
         * Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, 
         * программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
         * 
         * Халтурин Юрий
         */

        private const string Login = "root";
        private const string Password = "GeekBrains";
        public static void Task4()
        {
            int i = 0;
            do
            {
                Console.Write("Введите логин: ");
                var login = Console.ReadLine();
                Console.Write("Введите пароль: ");
                var password = Console.ReadLine();
                if (login == Login && password == Password)
                {
                    Console.WriteLine("Вы успешно авторизовались.");
                    break;
                }
                Console.WriteLine($"Введен неверный логин или пароль. Повторите попытку. Осталось попыток {2-i}");
                i++;
            } while (i < 3);

        }
    }
}