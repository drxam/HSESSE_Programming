using System;

namespace task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите фамилию: ");
            string a = Console.ReadLine();
            Console.WriteLine("Введите имя: ");
            string b = Console.ReadLine();
            Console.WriteLine("Введите отчество: ");
            string c = Console.ReadLine();
            Console.WriteLine("ФИО: " + a + " " + b + " " + c);
        }
    }
}
