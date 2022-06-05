using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Даны целые положительные числа A и B (A < B). Вывести все целые числа от A до B 
            включительно; каждое число должно выводиться на новой строке; при этом каждое число 
            должно выводиться количество раз, равное его значению (например, число 3 выводится
            3 раза). Например: если А = 3, а В = 7, то программа должна 
            сформировать в консоли следующий вывод:
                        3 3 3
                        4 4 4 4
                        5 5 5 5 5
                        6 6 6 6 6 6
                        7 7 7 7 7 7 7
             */

            //1.Ввод данных
            Console.WriteLine(" Введите два целых положительных произвольных числа: ");
            Console.Write(" Первое число - ");
            int numberA = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Второе число - ");
            int numberB = Convert.ToInt32(Console.ReadLine());

            //2.Проверка условий ввода
            if (numberA < 0)
            {
                numberA *= -1;
            }
            if (numberB < 0)
            {
                numberB *= -1;
            }
            if (numberA > numberB)
            {
                int temp = numberA;
                numberA = numberB;
                numberB = temp;
            }

            //3.Решение
            int count = numberA;
            for (int i = numberA; i <= numberB; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    Console.Write(" " + count);
                }
            Console.Write("\n");
            count++;
            }
            Console.WriteLine(" Расчет окончен. \n");
        }
    }
}

