using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    class Program
    {
        static int Sum(int x, int y)
        {
            return x + y;
        }

        static void Pause()
        {
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            int a = 0, b = 0;
            Console.WriteLine("Input a:");
            string str = Console.ReadLine();
            a = Convert.ToInt32(str);
            Console.WriteLine("Input b:");
            str = Console.ReadLine();
            b = Convert.ToInt32(str);
            int s = Sum(a, b);
            Console.WriteLine(s);
            Pause();
        }
    }
}
