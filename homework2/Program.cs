using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
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
                Console.WriteLine("4 - Task4");
                Console.WriteLine("5 - Task5");
                Console.WriteLine("6 - Task6");
                Console.WriteLine("7 - Task7");
                Console.WriteLine("0 - Exit");
                m = Convert.ToInt32(Console.ReadLine());
            }
            while (m < 0 && m > 7);
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
                        Homework2.Task1();
                        break;
                    case 2:
                        Homework2.Task2();
                        break;
                    case 3:
                        Homework2.Task3();
                        break;
                    case 4:
                        Homework2.Task4();
                        break;
                    case 5:
                        Homework2.Task5();
                        break;
                    case 6:
                        Homework2.Task6();
                        break;
                    case 7:
                        Homework2.Task7();
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
