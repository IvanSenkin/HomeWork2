using System;

namespace EX2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a < 10)
            {
                Console.WriteLine("Количество цифр в числе 1");
            }
            else
            {
                for (int i = 0; ; i++)
                {
                    a = a / 10;

                    if (a < 10)
                    {
                        Console.WriteLine(i + 2);
                        break;
                    }
                }
            }
        }
    }
}


