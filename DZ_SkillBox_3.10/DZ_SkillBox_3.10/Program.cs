using System;
using System.Linq;

namespace DZ_SkillBox_3._10
{
    class Program
    {
        static public int number;
        static public bool cheack = true;

        static void Main(string[] args)
        {
            while (cheack)
            {
                Console.WriteLine();
                Console.WriteLine("Каталог функций:");
                Console.WriteLine("a) Определение четного или нечетного числа");
                Console.WriteLine("b) Игра в карты <<21>>");
                Console.WriteLine("c) Проверка простого числа");

                Console.Write("\nВыберите из каталога функцую для дальнейшей работы: ");

                char letter = Console.ReadKey().KeyChar;
                Console.WriteLine();
                ChooseMethod(letter);

                Console.Write("Хотите продолжить или закончить программу? (Y/N): ");

                char letterCheack = Console.ReadKey().KeyChar;
                if (letterCheack == 'N' || letterCheack == 'n')
                    cheack = false;
                else
                {
                    Console.Clear();
                }
            }
        }

        static void ChooseMethod(char letter)
        {
            switch (letter)
            {
                case 'a':
                    EvenAndOddNumbers();
                    break;
                case 'b':
                    BlackjackGame();
                    break;
                case 'c':
                    int n = 0;
                    Console.Write("Ваше число: ");
                    number = int.Parse(Console.ReadLine());
                    Console.WriteLine("Простые числа из диапазона ({0}, {1})", 0, number);
                    for (var i = 0u; i < n; i++)
                    {
                        if (IsPrimeNumber(i))
                        {
                            Console.Write($"{i} ");
                        }
                    }

                    PrimeNumbers(number);
                    break;
                default:
                    Console.WriteLine("Вы ввели не правильно...");
                    break;
            }
        }

        /// <summary>
        /// Метод для определения четного или нечетного числа
        /// </summary>
        static void EvenAndOddNumbers()
        {
            Console.Write("Введите число: ");
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 1)
            {
                Console.WriteLine("число нечетное");

            }
            else
            {
                Console.WriteLine("Число четное");
            }
        }

        /// <summary>
        /// Игра в Блэкджек
        /// </summary>
        /// <param name="n"></param>
        static void BlackjackGame()
        {
            Console.Write("Сколько карт у вас на руке: ");
            int n = int.Parse(Console.ReadLine());
            int result = n.ToString().Sum(c => Convert.ToInt32(c));
            Console.WriteLine(result);
        }

        static void PrimeNumbers(int n)
        {
            var count = 0u;
            var i = 0u;
            while (count < n)
            {
                if (IsPrimeNumber(i))
                {
                    Console.Write(i);
                    if (count < n - 1)
                    {
                        Console.Write(", ");
                    }
                    count++;
                }
                i++;
            }
        }

        public static bool IsPrimeNumber(uint n)
        {
            var result = true;

            if (n > 1)
            {
                for (var i = 2u; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }
            else
            {
                result = false;
            }

            return result;
        }
    }
}
