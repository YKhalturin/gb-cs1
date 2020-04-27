using System;

namespace homework2
{
    partial class Homework2
    {
        /*
         * 5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, 
         * нужно ли человеку похудеть, набрать вес или все в норме;
         * 
         * Халтури Юрий
         */
        public static void Task5()
        {
            Console.WriteLine("Добро пожаловать в прогрумму Анкета");
            Console.Write("Введите вашу массу тела в килограммах: ");
            string weightStr = Console.ReadLine();
            int weight = Convert.ToInt32(weightStr);
            Console.Write("Введите ваш рост в метрах: ");
            string heightStr = Console.ReadLine();
            double height = Convert.ToDouble(heightStr);
            double ind = weight / (height * height);
            Console.WriteLine($"Ваш индекс массы тела: {ind:F1}");

            if (ind < 18)
            {
                Console.WriteLine("Вам надо Набрать вес");
            }
            else if (ind > 25)
            {
                Console.WriteLine("Вам надо похудеть");
            }
            else
            {
                Console.WriteLine("У вас все в норме");
            }

        }
    }
}