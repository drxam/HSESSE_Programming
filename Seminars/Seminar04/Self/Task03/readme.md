Self 03. Задание 3
На основе проекта консольного приложения, подготовить программу, которая получает от пользователя целочисленное число (цифру 1, 2, 3 или 4) и два вещественных числа A и B (B не равно нулю). После чего программа выполняет с операндами А и В одно из арифметических действий, закодированных цифрами. 1 -2 сложение, 2 – вычитание, 3 – умножение, 4 – деление. Результат вывести на экран. При некорректных данных – выводить сообщение.
Пример ввода:
Введите код операции: 1
Введите А: 5
Введите В: 6,5
5 + 6,5 = 11,5
Справка по сравнению строк: https://learn.microsoft.com/ru-ru/dotnet/api/system.string.compare?view=net-6.0 
namespace self03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите код операции: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите A: ");
            double A = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите B: ");
            double B = double.Parse(Console.ReadLine());
            double result;
            bool f = false;
            if (B != 0)
            {
                switch (a)
                {
                    case 1:
                        result = A + B;
                        break;
                    case 2:
                        result = A - B;
                        break;
                    case 3:
                        result = A * B;
                        break;
                    case 4:
                        result = A / B;
                        break;
                    default:
                        Console.WriteLine("Данные некорректны");
                        result = 0;
                        f = true;
                        break;
                }
            }
            else
            {
                Console.WriteLine("B не должно быть равно 0");
                result = 0;
                f |= true;
            }
            if (!f)
            {
                Console.WriteLine(result);
            }
        }
    }
}
