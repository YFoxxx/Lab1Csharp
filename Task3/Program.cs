using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            double z1 = (Math.Sqrt(2 * b + 2 * Math.Sqrt(b * b - 4))) / ((Math.Sqrt(b * b - 4)) + b + 2);
            double z2 = 1 / Math.Sqrt(b + 2);
            Console.WriteLine("z1 = {0}\nz2 = {1}", z1, z2);
        }
    }
}