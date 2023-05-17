using System;
using System.Collections.Generic;
/*
    - Шепелев Данил
    - 17.05.2023
    - Задание было выполненно примерно за 2 часа 
 */


namespace Task_1
{
    class Program
    {
        public static void BinPrint(long number)
        {
            Console.Write("Число "+ number + " в двоичном представлении: ");
            int maxStep = -1;
            List <long> s = new List<long>();
            bool otrNumber = false;
            List <long> sNum = new List<long>();


            if (number < 0)
            {
                number *= -1;
                otrNumber = true;
            }

            long num = number;
            while (number > 0)//собираем двоичное число
            {
                s.Add(number % 2);
                number = number / 2;
            }

            maxStep += s.Count;

            if (num >= 0 && otrNumber == false)//вывод на экран для положительного числа
            {
                if (num == 0)
                    Console.WriteLine("0\n");
                else
                {
                    for (int i = maxStep; i >= 0; i--)
                        Console.Write(s[i]);

                    Console.WriteLine("\n");
                }
            }
            else//вывод на экран для отрицательного числа
            {
                int k = 0;
                while (true)
                {
                    if (num <= Math.Pow(2, k))
                    {
                        s.Add(0);
                        maxStep = k;
                        break;
                    }
                    else
                        k++;
                }
                if (num == Math.Pow(2, k))
                    s.Insert(maxStep, 0);
                else
                    s.Insert(maxStep, 1);

                Console.Write("\nОбратный код:\t\t");

                for (int i = 0; i < maxStep; i++)//XOR (формирование обратного кода)
                {
                    if (s[i] == 0)
                        s[i] = 1;
                    else
                        s[i] = 0;
                }

                for (int i = maxStep; i >= 0; i--)
                    Console.Write(s[i]);

                Console.Write("\nДополнительный код:\t");

                bool flag = true;
                for (int i = 0; i < maxStep; i++) //формирование дополнительного кода
                {
                    if (flag == true)
                    {
                        if (s[i] == 1)
                            sNum.Add(0);
                        else
                        {
                            sNum.Add(1);
                            flag = false;
                        }
                    }
                    else
                        sNum.Add(s[i]);
                }
                sNum.Add(1);

                for (int i = maxStep; i >= 0; i--)
                    Console.Write(sNum[i]);

                Console.WriteLine("\n");
            }
        }

        static void Main(string[] args)
        {
            BinPrint(0);

            BinPrint(12421244);

            BinPrint(-123456789);
        }
    }
}
