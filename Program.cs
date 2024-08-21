using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passowrd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = "1234";
            int numberAttempt = 3;
            bool isOpen = true;
            string enteredMessage;

            Console.WriteLine("Введите пароль");

            while (isOpen)
            {
                enteredMessage = Console.ReadLine();

                if (enteredMessage == password)
                {
                    Console.WriteLine("Вы совершенно правы вот вам ненужный факт: Слон - единственное животное с 4 коленями");
                    isOpen = false;
                }
                else
                {
                    Console.WriteLine($"Не верно, осталось {numberAttempt - 1} попыток");
                    numberAttempt--;
                }

                if (numberAttempt == 0)
                {
                    Console.WriteLine("Увы и ах, но пароль не верен, попыток больше нет");
                    isOpen = false;
                }
            }

            Console.ReadKey();
        }
    }
}
