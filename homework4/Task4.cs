using System;

namespace homework4
{
    /*
     * 4. *а) Реализовать класс для работы с двумерным массивом. Реализовать конструктор, заполняющий массив случайными числами. 
     * Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного, свойство, 
     * возвращающее минимальный элемент массива, свойство, возвращающее максимальный элемент массива, метод, 
     * возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out)
     * 
     * Юрий Халтурин
     */

    partial class Homework4
    {
        public class MyMultiArray
        {
            public int[,] a;

            public int Min
            {
                get
                {
                    int min = a[0,0];
                    for (int i = 0; i < a.GetLength(0); i++)
                    {
                        for (int j = 0; j < a.GetLength(1); j++)
                        {
                            if (a[i, j] < min) min = a[i,j];
                        }
                    }
                    return min;
                }

            }

            public int Max
            {
                get
                {
                    int max = a[0,0];
                    for (int i = 0; i < a.GetLength(0); i++)
                    {
                        for (int j = 0; j < a.GetLength(1); j++)
                        {
                            if (a[i, j] > max) max = a[i, j];
                        }
                    }
                    return max;
                }
            }

            public int[,] FillArray(int i, int j)
            {
                a = new int[i,j];
                Random r = new Random();
                for (i = 0; i < a.GetLength(0); i++)
                {
                    for (j = 0; j < a.GetLength(1); j++)
                    {
                        a[i, j] = r.Next(1, 100);
                    }                    
                }
                return a;
            }

            public MyMultiArray(int i, int j)
            {
                Console.WriteLine($"Создаем массив. Размерность a[{i},{j}]");
                FillArray(i, j);
            }

            public int Sum ()
            {
                Random r = new Random();
                int sum = 0;
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        sum += a[i, j];
                    }
                }
                return sum;
            }

            public int Sum(int number)
            {
                Random r = new Random();
                int sum = 0;
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (a[i, j] > number)
                        {
                            sum += a[i, j];
                        }                 
                    }
                }
                return sum;
            }

            public void MaxIndex( out int maxIndexRow, out int maxIndexColumn)
            {
                maxIndexRow = 0;
                maxIndexColumn = 0;
                int max = a[0, 0];
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (a[i, j] > max)
                        {
                            max = a[i, j];
                            maxIndexRow = i;
                            maxIndexColumn = j;
                        }
                    }
                }
            }

            public void Print()
            {
                Console.WriteLine("Печатаем массив: ");
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                        Console.Write("{0,5}", a[i, j]);
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        public static void Task4()
        {
            MyMultiArray myMultiArray = new MyMultiArray(3,4);
            myMultiArray.Print();
            Console.WriteLine($"Максимальный элемент массива: {myMultiArray.Max}");
            Console.WriteLine($"Минимальный элемент массива: {myMultiArray.Min}");
            Console.WriteLine($"Сумма элементов массива: {myMultiArray.Sum()}");
            Console.WriteLine($"Сумма элементов массива больше 50ти: {myMultiArray.Sum(50)}");
            myMultiArray.MaxIndex(out int i, out int j);
            Console.WriteLine($"Индекс максимального элемента массива: a[{i},{j}]");

        }
    }
}