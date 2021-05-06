using System;

namespace EX4
{
    class Program
    {
            //4.Реализовать метод проверки логина и пароля.На вход метода подается логин и пароль.
            //  На выходе истина, если прошел авторизацию, и ложь, если не прошел(Логин: root, Password: GeekBrains).
            //  Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа 
            //  пропускает его дальше или не пропускает.С помощью цикла do while ограничить ввод пароля тремя попытками.

      static bool LogPass(string Log, string Pass)
        {
            return (Log == "root" && Pass == "GeekBrains");
            
        }
        static void Main(string[] args)
        {
            string log;
            string pass;
            int i = 0;
            
            do
            {
                Console.WriteLine($"Попатыка {i+1}");
                Console.Write("Введите логин: ");
                log = Console.ReadLine();
                Console.Write("Введите пароль: ");
                pass = Console.ReadLine();
               if (LogPass(log, pass))
                {
                    Console.WriteLine("Верно");
                    break;
                }
                i++;

            } while (i < 3);

            if (i > 2)
            {
                Console.WriteLine("Вы ввели максимальное число попыток");
            }
            }
    }
}
