using SecondLabIVT2;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // Создаем экземпляр класса для доступа к методам
        SecondLabFunctions labFunctions = new SecondLabFunctions();

        Console.WriteLine("1) Решить квадратное уравнение (a, b, c)");
        Console.WriteLine("2) Приближённое вычисление числа pi (ввод слагаемых от пользователя)");
        Console.WriteLine("3) Вывести на экран кол-во четырехзначных чисел в ряде Фибоначчи");
        Console.WriteLine("4) Вычислить приближенное cos(x) по формуле Тейлора (ввод x и q)");
        Console.WriteLine("5) Найти комбинации натурального числа N");
        Console.WriteLine("6) Правильное окончание слова (лет/год/года)");
        Console.WriteLine("7) Разность 3 чисел (3 числа)");
        Console.WriteLine("8) Все двузначные числа, которые делятся на 5");

        int userChoice = int.Parse(Console.ReadLine());

        switch (userChoice)
        {
            case 1:
                Console.WriteLine("Решаем уравнение: ax^2 + bx + c = 0");
                Console.Write("Введите a: ");
                double letterA = double.Parse(Console.ReadLine());
                Console.Write("Введите b: ");
                double letterB = double.Parse(Console.ReadLine());
                Console.Write("Введите c: ");
                double letterC = double.Parse(Console.ReadLine());
                labFunctions.ReshenieDiskriminant(letterA, letterB, letterC);
                break;

            case 2:
                Console.WriteLine("Введите количество операций: ");
                int numberOfOperations = int.Parse(Console.ReadLine());
                labFunctions.ChisloPi(numberOfOperations);
                break;

            case 3:
                Console.Write("Введите количество операций: ");
                int numberOfOper = int.Parse(Console.ReadLine());
                labFunctions.RyadFib(numberOfOper);
                break;

            case 4:
                labFunctions.RyadTayl();
                break;

            case 5:
                labFunctions.CombinationFind();
                break;

            case 6:
                Console.WriteLine("Введите число от 1 до 100: ");
                int year = int.Parse(Console.ReadLine());

                if (year < 1 || year > 100)
                {
                    Console.WriteLine("Число должно быть в диапазоне от 1 до 100");
                    return;
                }
                labFunctions.Okonchanie(year);
                break;

            case 7:
                Console.WriteLine("Введите два числа:");
                double num1 = double.Parse(Console.ReadLine());
                double num2 = double.Parse(Console.ReadLine());

                if (num1 < 0 || num2 < 0)
                {
                    Console.WriteLine("Error: числа не могут быть отрицательными.");
                }
                else
                {
                    double smallerNum = Math.Min(num1, num2);
                    double squareRoot = Math.Sqrt(smallerNum);
                    Console.WriteLine($"Квадратный корень меньшего числа: {squareRoot}");
                }
                break;

            case 8:
                Console.WriteLine("Введите число от 1 до 10000:");
                int number = int.Parse(Console.ReadLine());

                if (number < 1 || number > 10000)
                {
                    Console.WriteLine("Число должно быть от 1 до 10000.");
                    return;
                }

                Console.WriteLine($"Нечетные делители числа {number}:");
                for (int i = 1; i <= number; i += 2)
                {
                    if (number % i == 0)
                    {
                        Console.Write($"{i} ");
                    }
                }
                Console.WriteLine();
                break;

            default:
                Console.WriteLine("Неверный выбор. Пожалуйста, выберите число от 1 до 8.");
                break;
        }
    }
}
