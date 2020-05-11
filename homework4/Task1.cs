using System;
using System.Security.AccessControl;

namespace homework4
{
    /*
     * 1. Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно. 
     * Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых хотя бы одно число делится на 3. 
     * В данной задаче под парой подразумевается два подряд идущих элемента массива. 
     * Например, для массива из пяти элементов: 6; 2; 9; –3; 6 – ответ: 4.
     * 
     * Халтурин Юрий
     */

    partial class Homework4
    {
        public static int[] FillArray(int count, int min, int max)
        {
            int[] arr = new int[count];
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(min, max);
            }
            return arr;
        }

        static void Print(int[] a)
        {
            for (int i = 0; i < a.Length; i++) Console.Write("{0} ", a[i]);
            Console.WriteLine();
        }

        public static void Task1()
        {
            var arr = FillArray(20, -10000, 10000);
            Console.WriteLine("Исходные данные");
            Print(arr);
            int pairs = 0;
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] != 0)
                {
                    if (arr[i] % 3 == 0 || arr[i + 1] % 3 == 0)
                    {
                        Console.WriteLine($"Пара {arr[i]} и {arr[i+1]}");
                        pairs++;
                    }
                }
            }       
            Console.WriteLine($"Количество пар = {pairs}");
        }
    }
}