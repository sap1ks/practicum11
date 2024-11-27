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
            int h = Input("Кол-во часов");
            int m = Input("Кол-во минут");
            int s = Input("Кол-во секунд");
            int seconds = Seconds(h, m, s);
            Output(seconds);
            Console.ReadKey();
        }
        static int Seconds(int h,int m,int s)
        {
            return h * 3600 + m * 60 + s;
        } 
        static int Input(string message)
        {
            Console.WriteLine(message);
            return int.Parse(Console.ReadLine());
        }
        static void Output(int seconds)
        {
            Console.WriteLine($"Всего секунд:{seconds}");
        }
    }
}
