using System;

namespace task06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину первого катета:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длину второго катета:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Длина гипотенузы равна " + Math.Sqrt(a*a + b*b));
        }
    }
}
