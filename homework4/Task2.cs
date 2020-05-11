using System;
using System.IO;

namespace homework4
{
    /*
     * 2. а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий массив заданной размерности 
     * и заполняющий массив числами от начального значения с заданным шагом. Создать свойство Sum, которые возвращают сумму элементов массива,
     * метод Inverse, меняющий знаки у всех элементов массива, метод Multi, умножающий каждый элемент массива на определенное число, 
     * свойство MaxCount, возвращающее количество максимальных элементов. В Main продемонстрировать работу класса.
     * б)Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
     * 
     * Юрий Халтрурин
     */

    partial class Homework4
    {
        public class MyArray
        {
            public int[] a;

            public int Sum
            {
                get
                {
                    int sum = 0;
                    for (int i = 0; i < a.Length; i++)
                    {
                        sum += a[i];
                    }                       
                    return sum;
                }

            }

            public int MaxCount
            {
                get
                {
                    int max = a[0];
                    int maxCount = 1;
                    for (int i = 1; i < a.Length; i++)
                    {
                        if (a[i] == max)
                        {
                            maxCount++;
                        }
                        if (a[i] > max)
                        {
                            max = a[i];
                            maxCount = 1;
                        }
                    }
                    return maxCount;
                }
            }

            public MyArray(int count, int initialNumber, int step)
            {
                Console.WriteLine($"Создаем массив. Размерность a[{count}], начиная с {initialNumber}, шаг {step} ");
                a = new int[count];
                a[0] = initialNumber;
                for (int i = 1; i < a.Length; i++)
                {
                    a[i] = a[i-1] + step;
                }
            }

            public void ReadFromFile(string filename)
            {
                StreamReader sr = new StreamReader(filename);
                int i = 0;
                int count = int.Parse(sr.ReadLine() ?? throw new InvalidOperationException());
                a = new int[count];
                while (!sr.EndOfStream)  // Пока не конец потока (файла)
                {
                    string s = sr.ReadLine();
                    Console.WriteLine("Считали строку:" + s);
                    try
                    {
                        int number = int.Parse(s);
                        a[i] = number;
                        i++;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                sr.Close();
            }

            public MyArray(string filename)
            {
                ReadFromFile(filename);
            }

            public int[] Inverse()
            {
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = -a[i];
                }
                return a;
            }

            public int[] Multi(int number)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = a[i] * number;
                }
                return a;
            }


            public void Print()
            {
                Console.Write("Печатаем массив: ");
                for (int i = 0; i < a.Length; i++) Console.Write("{0} ", a[i]);
                Console.WriteLine();
            }

            public void WriteToFile(string filename)
            {
                StreamWriter sw;
                sw = new StreamWriter(filename);
                sw.WriteLine(a.Length);
                foreach (int item in a)
                {
                    sw.WriteLine(item.ToString());
                }                
                sw.Close();
            }
        }

        public static void Task2()
        {
            Console.WriteLine("================== Первый конструктор ====================");
            Console.WriteLine("Считываем данные из файла array.txt");
            MyArray myArray1 = new MyArray("..\\..\\array.txt");
            myArray1.Print();
            Console.WriteLine($"Сумма элементов массива: {myArray1.Sum}");
            Console.WriteLine($"Количество максимальных элементов в массиве: {myArray1.MaxCount}");

            Console.WriteLine("================== Второй конструктор ====================");
            MyArray myArray2 = new MyArray(10, 1, 2);
            myArray2.Print();
            int n = 5;
            Console.WriteLine($"Умножаем каждый элемент массива на {n}");
            myArray2.Multi(n);
            myArray2.Print();
            Console.WriteLine("Меняем знак в массиве на противоположный");
            myArray2.Inverse();
            myArray2.Print();
            string fileToWrite = "..\\..\\array2.txt";
            Console.WriteLine("Записываем данные в файл array2.txt");
            myArray2.WriteToFile(fileToWrite);
            Console.WriteLine("Считываем данные из файла");
            myArray2 = new MyArray(fileToWrite);
            myArray2.Print();
        }
    }
}