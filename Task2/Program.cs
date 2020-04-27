using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /*Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); 
     * где m — масса тела в килограммах, h — рост в метрах
     * 
     * Халтурин Юрий
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
            Console.Write("Введите вашу массу тела в килограммах: ");
            string weightStr = Console.ReadLine();
            int weight = Convert.ToInt32(weightStr);
            Console.Write("Введите ваш рост в метрах: ");
            string heightStr = Console.ReadLine();
            double height = Convert.ToDouble(heightStr);
            double ind = weight / (height * height);
            
            Console.WriteLine($"Ваш индекс массы тела: {ind:F1}");
            Pause();
        }
    }
}
