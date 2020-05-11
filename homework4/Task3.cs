using System;
using System.IO;

namespace homework4
{
    /*
     * 3. Решить задачу с логинами из предыдущего урока, только логины и пароли считать из файла в массив. 
     * Создайте структуру Account, содержащую Login и Password.
     * 
     * Юрий Халтурин
     */

    partial class Homework4
    {
        private const string Login = "root";
        private const string Password = "GeekBrains";

        public struct Account
        {
            public string Login;
            public string Password;

            public Account(string login, string password)
            {
                Login = login;
                Password = password;
            }
        }

        public static bool CheckCredentials(string login, string password)
        {
            return login == Login && password == Password;
        }

        public static Account[] ReadFromFile(string filename)
        {
            StreamReader sr = new StreamReader(filename);
            int count = int.Parse(sr.ReadLine() ?? throw new InvalidOperationException());
            Account[] a = new Account[count];
            int i = 0;
            while (!sr.EndOfStream)  // Пока не конец потока (файла)
            {
                string s = sr.ReadLine();
                Console.WriteLine($"Считали логин и пароль {i+1}: " + s);
                try
                {
                    var s1= s?.Split(':');
                    if (s1 != null)
                    {
                        a[i].Login = s1[0];
                        a[i].Password = s1[1];
                    }
                    i++;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            sr.Close();
            return a;
        }

        public static void Task3()
        {
            var a = ReadFromFile("..\\..\\credentials.txt");
            int i = 0;
            int tryCount = 5;
            do
            {
                Console.WriteLine($"Пытаемся ввести логин: {a[i].Login} и пароль:{a[i].Password}");
                if (CheckCredentials(a[i].Login, a[i].Password))
                {
                    Console.WriteLine("Вы успешно авторизовались.");
                    break;
                }
                Console.WriteLine($"Введен неверный логин или пароль. Повторите попытку. Осталось попыток {tryCount -1 - i}");
                i++;
            } while (i < tryCount);
            
        }
    }
}