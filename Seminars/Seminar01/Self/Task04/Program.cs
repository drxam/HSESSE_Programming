using System;

namespace task04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Введите имя: ");
            string a = Console.ReadLine();
            Console.WriteLine("Здравствуйте, " + a + "!");
        }
    }
}
