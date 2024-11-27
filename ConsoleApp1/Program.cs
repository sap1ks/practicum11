using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = Input("Кол-во км");
            int m = Input("Кол-во м");
            int meters=Meters(k, m);
            Output(meters);
            Console.ReadKey();
        }
        static int Meters(int k, int m)
        {
            return k * 1000 + m;
        }
        static int Input(string message)
        {
            Console.WriteLine(message);
            return int.Parse(Console.ReadLine());
        }
        static void Output(int meters)
        {
            Console.WriteLine($"Всего метров:{meters}");

    }


    }
}
