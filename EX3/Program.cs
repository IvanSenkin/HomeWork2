using System;

namespace EX3
{
    class Program
    {
        static void Main(string[] args)
        {
           

            for (int i = 0; ; i++)

            {
                Console.WriteLine("Введите число 1");
                a = Convert.ToDouble(Console.ReadLine());
                double c = a;

                if (a > 0 && a % 2! == 0)
                {
                    c = c + a;

                    Console.WriteLine("Summ: " + c);
                }
                else
                {
                    Console.WriteLine($"Введите число {i}");
                    a = Convert.ToDouble(Console.ReadLine());

                }
            }

        }
    }
}