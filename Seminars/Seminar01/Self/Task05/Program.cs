using System;

namespace task05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение напряжения U:");
            double u = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение сопротивления R:");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Сила тока равна " + (u / r) + " амперам");
            Console.WriteLine("Потребляемая мощность электрической цепи равна " + (u * u / r) + " ваттам");
        }
    }
}
