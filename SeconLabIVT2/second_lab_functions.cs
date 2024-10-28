using System;

namespace SecondLabIVT2
{
    internal class SecondLabFunctions
    {
        // Метод решения дискриминанта
        public void ReshenieDiskriminant(double a, double b, double c)
        {
            double diskriminant = b * b - 4 * a * c;

            if (diskriminant > 0)
            {
                Console.WriteLine($"D={diskriminant}");
                double x1 = (-b + Math.Sqrt(diskriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(diskriminant)) / (2 * a);
                Console.WriteLine($"x1 = {x1}, x2 = {x2}");
            }
            else if (diskriminant == 0)
            {
                Console.WriteLine($"D={diskriminant}");
                double x1 = -b / (2 * a);
                Console.WriteLine($"x1 = {x1}");
            }
            else
            {
                Console.WriteLine($"D={diskriminant}");
                Console.WriteLine("Действительных корней нет. Ответ в виде комплексных чисел: ");
                diskriminant = Math.Abs(diskriminant);
                double x1 = -b / (2 * a);
                Console.WriteLine($"x1={x1}-{Math.Sqrt(diskriminant)}i, x2={x1}+{Math.Sqrt(diskriminant)}i");
            }
        }

        // Метод для расчета числа Пи
        public void ChisloPi(int numberOfOperations)
        {
            if (numberOfOperations < 0)
            {
                Console.WriteLine("Нельзя сделать отрицательное кол-во операций");
                return;
            }

            Console.WriteLine($"Количество слагаемых для вычисления: {numberOfOperations}");

            double pi_4 = 0.0;
            int currentSymbol = 1;

            for (int i = 0; i < numberOfOperations; i++)
            {
                int denominator = 2 * i + 1;
                double term = currentSymbol / (double)denominator;
                pi_4 += term;
                string sign = currentSymbol == 1 ? "+" : "-";
                Console.WriteLine($"Шаг {i + 1}: текущее слагаемое = {sign} 1/{denominator}, сумма для pi/4 = {pi_4}");
                currentSymbol *= -1;
            }
            double pi = pi_4 * 4;
            Console.WriteLine($"Приближенное значение pi={pi}");
        }

        // Метод для ряда Фибоначчи
        public void RyadFib(int numberOfOperations)
        {
            double[] f = new double[numberOfOperations];
            int numberOf4DigitNumbers = 0;

            for (int i = 0; i < numberOfOperations; i++)
            {
                if (i < 2)
                    f[i] = 1;
                else
                    f[i] = f[i - 1] + f[i - 2];
                if (f[i] >= 1000 && f[i] <= 9999)
                    numberOf4DigitNumbers++;

                Console.WriteLine($"Шаг {i} f = {f[i]}");
            }
            Console.WriteLine($"Всего 4-х значных элементов: {numberOf4DigitNumbers}");
        }

        // Вспомогательный метод для вычисления факториала
        private double Factorial(int n)
        {
            double result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        // Метод для вычисления ряда Тейлора
        public void RyadTayl()
        {
            double q;
            int x;
            Console.WriteLine("Введите значение x: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите Q: ");
            q = double.Parse(Console.ReadLine());

            double tmp = 0;
            int step = 2;
            do
            {
                if (step == 2)
                    tmp = 1;
                else
                {
                    tmp = step % 4 != 0 ?
                        tmp - (Math.Pow(x, step) / Factorial(step)) :
                        tmp + (Math.Pow(x, step) / Factorial(step));
                }
                Console.WriteLine($"Шаг = {step} вычисление = {tmp} < {q}");
                step += 2;

            } while (tmp >= q);
        }

        // Метод для поиска комбинаций кубов чисел, равных N
        public void CombinationFind()
        {
            int n;

            Console.WriteLine("Введите N>0");
            n = int.Parse(Console.ReadLine());

            double result = 0;
            bool find = false;
            int x = 0, y = 0, z = 0;

            for (x = 0; x < n; x++)
                for (y = 0; y < n; y++)
                    for (z = 0; z < n; z++)
                    {
                        result = Math.Pow(x, 3) + Math.Pow(y, 3) + Math.Pow(z, 3);

                        if (result == n)
                        {
                            Console.WriteLine(find ?
                                "В ходе перебора нашли значение x^3 + y^3 + z^3 = N" :
                                "В ходе перебора не нашли значения x^3 + y^3 + z^3 = N");
                            Console.WriteLine($"{x}^3 + {y}^3 + {z}^3 = {n}");
                            find = true;
                        }
                    }
            if (!find)
                Console.WriteLine("Ничего не найдено!");
        }

        // Метод для вывода окончания года
        public void Okonchanie(int year)
        {
            int lastDigit = year % 10;
            int lastTwoDigits = year % 100;

            if (lastTwoDigits >= 11 && lastTwoDigits <= 14)
            {
                Console.WriteLine($"{year} лет");
            }
            else if (lastDigit == 1)
            {
                Console.WriteLine($"{year} год");
            }
            else if (lastDigit >= 2 && lastDigit <= 4)
            {
                Console.WriteLine($"{year} года");
            }
            else
            {
                Console.WriteLine($"{year} лет");
            }
        }
    }
}