using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    /*
     * 6. *Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).
     * 
     * Халтурин Юрий
     */

    class Helper
    {
        public static void Pause()
        {
            Console.ReadKey();
        }

        public static double DistanceBetweenPoints(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        public static void Print(string message, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(message);
        }
    }
}
