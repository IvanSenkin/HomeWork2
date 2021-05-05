using System;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите второе число: "); // a
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: "); // b
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите третье число: "); // c
            double c = Convert.ToDouble(Console.ReadLine());
            if (a < b && a < c)
            {
                Console.WriteLine($"Меньшее число {a}");
            } else if ( b < c )
            {
                Console.WriteLine($"Меньшее число {b}");
            }
            else
            {
                Console.WriteLine($"Меньшее число {c}");
            }
        }
    }
}
