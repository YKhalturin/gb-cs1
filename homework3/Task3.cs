using System;
using System.Diagnostics.Eventing.Reader;

namespace homework3
{
    /*
     * 3. *Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел. 
     * Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
     * Написать программу, демонстрирующую все разработанные элементы класса.
     * ** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
     * Добавить упрощение дробей.
     * 
     * Халтурин Юрий
     */
    partial class Homework3
    {
        class Fraction
        {
            private int Numerator { get; }
            private int Denominator { get; }

            public Fraction(int numerator, int denominator)
            {
                if (denominator == 0) throw new ArgumentException("Знаменатель не может равняться 0");
                Numerator = numerator;
                Denominator = denominator;
            }

            public Fraction Addition(int numerator, int denominator)
            {
                int numeratorResult = Numerator * denominator + numerator * Denominator;
                int denominatorResult = Denominator * denominator;
                return new Fraction(numeratorResult, denominatorResult);
            }

            public Fraction Subtraction(int numerator, int denominator)
            {
                int numeratorResult = Numerator * denominator - numerator * Denominator;
                int denominatorResult = Denominator * denominator;
                return new Fraction(numeratorResult, denominatorResult);
            }

            public Fraction Multiplication(int numerator, int denominator)
            {
                int numeratorResult = Numerator * numerator;
                int denominatorResult = Denominator * denominator;
                return new Fraction(numeratorResult, denominatorResult);
            }

            public Fraction Division(int numerator, int denominator)
            {
                int numeratorResult = Numerator * denominator;
                int denominatorResult = Denominator * numerator;
                return new Fraction(numeratorResult, denominatorResult);
            }

            int Min(int a, int b)
            {
                return a < b ? a : b;
            }

            public Fraction Reduction()
            {
                var numeratorResult = Numerator;
                var denominatorResult = Denominator;
                var absNumerator = Math.Abs(Numerator);
                var absDenominator = Math.Abs(Denominator);
                var min = Min(absNumerator, absDenominator);

                for (int i = min; i > 1; i--)
                {
                    if (Numerator % i == 0 && Denominator % i == 0)
                    {
                        numeratorResult = Numerator / i;
                        denominatorResult = Denominator / i;
                        break;
                    }
                }
                return new Fraction(numeratorResult, denominatorResult);
            }

            public void Print(string message)
            {
                Console.WriteLine($"{message}{Numerator}/{Denominator}");
            }

            public void PrintWithHWholePart(string message)
            {
                var n = Numerator;
                var d = Denominator;
                var i = 0;
                while (n > d)
                {
                    n -= d;
                    i++;
                }
                if (i > 0)
                {
                    Console.WriteLine($"{message}{i}#{n}/{d}");
                }
                else
                {
                    Console.WriteLine($"{message}{n}/{d}");
                }
                
            }

        }

        public static void Task3()
        {
            var fraction = new Fraction(1, 2);
            Console.WriteLine("Без сокращения дробей");
            fraction.Addition(3, 4).Print("1/2 + 3/4 = ");
            fraction.Subtraction(3, 4).Print("1/2 - 3/4 = ");
            fraction.Multiplication(3, 4).Print("1/2 * 3/4 = ");
            fraction.Division(3, 4).Print("1/2 : 3/4 = ");
            Console.WriteLine("С сокращением(упрощением) дробей");
            fraction.Addition(3, 4).Reduction().Print("1/2 + 3/4 = ");
            fraction.Subtraction(3, 4).Reduction().Print("1/2 - 3/4 = ");
            fraction.Multiplication(3, 4).Reduction().Print("1/2 * 3/4 = ");
            fraction.Division(3, 4).Reduction().Print("1/2 : 3/4 = ");
            Console.WriteLine("С вынесением целой части");
            fraction.Addition(3, 4).Reduction().PrintWithHWholePart("1/2 + 3/4 = ");
            fraction.Addition(7, 3).Reduction().PrintWithHWholePart("1/2 + 7/3 = ");
        }
    }
}
