using System;

namespace task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите фамилию: ");
            string fam = Console.ReadLine();
            Console.WriteLine("Введите имя: ");
            string im = Console.ReadLine();
            Console.WriteLine("Введите отчество: ");
            string otch = Console.ReadLine();
            Console.WriteLine("Фамилия: " + fam);
            Console.WriteLine("Имя: " +  im);
            Console.WriteLine("Отчество: " + otch);
        }
    }
}
