using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Task1
{
    class Program1
    {
        static void Main()
        {
            Console.WriteLine("Введите ваше имя");
            string? name = Console.ReadLine();
            Console.WriteLine($"Добро пожаловать, {name}!");
        }
    }
}
