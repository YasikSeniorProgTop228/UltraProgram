using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Програма 1: Зміна порядку цифр
            Console.WriteLine("Введіть ціле число (не менше 5 цифр):");
            int number = int.Parse(Console.ReadLine());
            int reversedNumber = ReverseNumber(number);
            Console.WriteLine("Результат: " + reversedNumber);

            // Програма 2: Видалення перших X слів
            Console.WriteLine("Введіть речення:");
            string sentence = Console.ReadLine();
            Console.WriteLine("Введіть число X:");
            int x = int.Parse(Console.ReadLine());
            string resultSentence = RemoveWords(sentence, x);
            Console.WriteLine("Результат: " + resultSentence);

            // Програма 3: Обчислення площі фігури
            Console.WriteLine("Яку площу фігури ви хочете отримати? (Квадрат/Круг/Прямокутник/Трикутник)");
            string shape = Console.ReadLine().ToLower();
            double area = CalculateArea(shape);
            Console.WriteLine("Площа: " + area);

            // Програма 4: Заміна символів
            Console.WriteLine("Введіть будь-який текст:");
            string inputText = Console.ReadLine();
            string modifiedText = ReplaceCharacters(inputText);
            Console.WriteLine("Результат: " + modifiedText);
        }

        static int ReverseNumber(int num)
        {
            bool isNegative = num < 0;
            num = Math.Abs(num);
            int reversed = 0;

            while (num > 0)
            {
                int digit = num % 10;
                reversed = reversed * 10 + digit;
                num /= 10;
            }

            return isNegative ? -reversed : reversed;
        }

        static string RemoveWords(string sentence, int x)
        {
            string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (x >= words.Length)
            {
                return string.Empty;
            }
            return string.Join(" ", words, x, words.Length - x);
        }

        static double CalculateArea(string shape)
        {
            double area = 0;

            switch (shape)
            {
                case "квадрат":
                    Console.WriteLine("Введіть розмір сторони:");
                    double side = double.Parse(Console.ReadLine());
                    area = side * side;
                    break;

                case "круг":
                    Console.WriteLine("Введіть розмір радіуса:");
                    double radius = double.Parse(Console.ReadLine());
                    area = Math.PI * radius * radius;
                    break;

                case "прямокутник":
                    Console.WriteLine("Введіть розмір двох сторін:");
                    double length = double.Parse(Console.ReadLine());
                    double width = double.Parse(Console.ReadLine());
                    area = length * width;
                    break;

                case "трикутник":
                    Console.WriteLine("Введіть розмір основи та висоти трикутника:");
                    double baseLength = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    area = (baseLength * height) / 2;
                    break;

                default:
                    Console.WriteLine("Невідома фігура");
                    break;
            }

            return area;
        }

        static string ReplaceCharacters(string text)
        {
            char[] result = text.ToCharArray();
            for (int i = 0; i < result.Length; i++)
            {
                if ((i + 1) % 3 == 0 && (i + 1) % 15 != 0)
                {
                    result[i] = 'X';
                }
                else if ((i + 1) % 5 == 0 && (i + 1) % 15 != 0)
                {
                    result[i] = '9';
                }
                else if ((i + 1) % 15 == 0)
                {
                    result[i] = '?';
                }
            }
            return new string(result);
        }
    }
}
