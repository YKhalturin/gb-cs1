using System;
using System.IO;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;

namespace homework5
{
    /*
     * 2. Разработать класс Message, содержащий следующие статические методы для обработки текста:
     * а) Вывести только те слова сообщения, которые содержат не более n букв.
     * б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
     * в) Найти самое длинное слово сообщения.
     * г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
     * Продемонстрируйте работу программы на текстовом файле с вашей программой.
     * 
     * Халтурин Юрий
     */

    partial class Homework5
    {

        public class Message
        {
            public static void GetWords(MatchCollection matches, int length)
            {
                var sb = new StringBuilder();
                Console.WriteLine($"Выводим слова длина которых не превышает {length} символов");
                foreach (Match m in matches)
                {
                    if (m.Length <= length)
                    {
                        sb.Append($"{m.Value}({m.Length}) " );
                    }
                }
                Console.WriteLine(sb);
            }
            public static void RemoveWords(MatchCollection matches, char symbol)
            {
                var sb = new StringBuilder();
                Console.WriteLine($"Удаляем из текста, слова, которые заканчиваются на символ '{symbol}'. В скобках [удаленное слово]");
                foreach (Match m in matches)
                {
                    var lastSymbol = m.Value.Substring(m.Value.Length-1, 1);
                    if (String.Compare(lastSymbol, symbol.ToString(), StringComparison.Ordinal) != 0)
                    {
                        sb.Append(m.Value + " ");
                    }
                    else
                    {
                        sb.Append($"[{m.Value}] ");
                    }
                }
                Console.WriteLine(sb);
            }

            private static string LongestWord(MatchCollection matches)
            {
                var longestWord = matches[0].Value;
                foreach (Match m in matches)
                {
                    if (m.Length > longestWord.Length)
                    {
                        longestWord = m.Value;
                    }
                }
                return longestWord;
            }
            public static void GetLongestWord(MatchCollection matches)
            {
                Console.WriteLine($"Находим самое длинное слово");
                var longestWord = LongestWord(matches);
                Console.WriteLine($"Самое длинное слово: {longestWord}({longestWord.Length})");
            }
            public static void GetLongestSequence(MatchCollection matches)
            {
                var sb = new StringBuilder();
                Console.WriteLine($"Находим самые длинные слова");
                var longestWord = LongestWord(matches);
                foreach (Match m in matches)
                {
                    if (m.Length == longestWord.Length)
                    {
                        sb.Append($"{m.Value} ");
                    }
                }
                Console.WriteLine($"Самые длинные слова: {sb}");
            }
        }

        public static void Task2()
        {
            string text = File.ReadAllText("Data.txt", Encoding.GetEncoding(1251));

            Regex regEx = new Regex(@"\b\w+\b", RegexOptions.IgnoreCase);
            MatchCollection matches = regEx.Matches(text);
            Console.WriteLine($"{text}");
            Console.WriteLine($"Слов в тексте: {matches.Count}");
            Console.WriteLine();
            Message.GetWords(matches, 4);
            Console.WriteLine();
            Message.RemoveWords(matches, 'е');
            Console.WriteLine();
            Message.GetLongestWord(matches);
            Console.WriteLine();
            Message.GetLongestSequence(matches);
        }
    }
}