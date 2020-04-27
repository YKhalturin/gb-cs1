using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        /* а) Написать программу, которая подсчитывает расстояние между точками с 
         * координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). 
         * Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
         * б) *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;
         * 
         * Халтурин Юрий
         */

        static void Pause()
        {
            Console.ReadKey();
        }

        static double DistanceBetweenPoints(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        static void Main(string[] args)
        {
            Console.Write("Введите координаты первой точки x1: ");
            string x1Str = Console.ReadLine();
            int x1 = Convert.ToInt32(x1Str);
            Console.Write("Введите координаты первой точки y1: ");
            string y1Str = Console.ReadLine();
            int y1 = Convert.ToInt32(y1Str);
            Console.Write("Введите координаты второй точки x2: ");
            string x2Str = Console.ReadLine();
            int x2 = Convert.ToInt32(x2Str);
            Console.Write("Введите координаты второй точки y2: ");
            string y2Str = Console.ReadLine();
            int y2 = Convert.ToInt32(y2Str);

            double distanceBetweenPoints = DistanceBetweenPoints(x1, y1, x2, y2);

            Console.WriteLine($"Расстояние между точками: {distanceBetweenPoints:F2}");
            Pause();
        }
    }
}
