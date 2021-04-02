using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
    class Program
    {
        static int Menu()
        {
            int m;
            do
            {
                Console.WriteLine("1 - Task1");
                Console.WriteLine("2 - Task2");
                Console.WriteLine("3 - Task3");
                Console.WriteLine("0 - Exit");
                m = Convert.ToInt32(Console.ReadLine());
            }
            while (m < 0 && m > 3);
            return m;
        }

        static void Main(string[] args)
        {
            int menu;
            do
            {
                menu = Menu();
                switch (menu)//goto menu
                {
                    case 1:
                        Homework6.Task1();
                        break;
                    case 2:
                        Homework6.Task2();
                        break;
                    case 3:
                        Homework6.Task3();
                        break;
                    default:
                        Console.WriteLine("Bye!");
                        break;
                }
            }
            while (menu != 0);
        }
    }
}
