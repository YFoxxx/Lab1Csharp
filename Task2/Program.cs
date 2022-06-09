using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Prog2
{
    class Prog
    {
        static void Main(string[] args)
        {
            OperatingSystem os = System.Environment.OSVersion;
            Console.WriteLine("Версия ОС: {0}", os);
            Console.WriteLine("Текущее время и дата: " + System.DateTime.Now);
        }
    }
}
