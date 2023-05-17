using System;
using System.Text;
/*
    - Шепелев Данил
    - 17.05.2023
    - Задание было выполненно менее чем за 30 минут 
 */

namespace Task_2
{
    class Program
    {
        static void RemoveDups(StringBuilder str)
        {
            for(int i = 0; i < str.Length - 1; i++)
            {
                if(str[i] == str[i + 1])
                {
                    str = str.Remove(i, 1);
                    i--;
                }
            }
        }

        static void Main(string[] args)
        {
            StringBuilder str = new StringBuilder("AAA BB B CcC");

            RemoveDups(str);

            Console.WriteLine(str);
        }
    }
}
