Self 05. Задание 5.
На основе проекта консольного приложения, подготовить программу решения квадратного уравнения, заданного вещественными коэффициентами a, b и c. На экран программа выводит уравнение в виде: a*x^2 + b*x + c = 0 и корни x1 и x2. При подготовке кода программы требуется учесть специальные случаи.
Специальные случаи:
1. a = 0 – вырожденный случай, один корень
2. b = 0 – два совпадающих корня
3. Дискриминант меньше нуля
	1. Простой вариант: вывод сообщения «Нет действительных корней»
	2. Вариант сложный: сформировать и вывести на экран значения комплексных корней
namespace self05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool f = false;
            double a = double.Parse(Console.ReadLine()), b = double.Parse(Console.ReadLine()), c = double.Parse(Console.ReadLine()), x1 = -1000, x2 = -1000;
            string b1 = b >= 0 ? " + " : " "; 
            string c1 = c >= 0 ? " + " : " ";
            double d = b * b - 4 * a * c;
            if (a != 0)
            {
                if (d > 0)
                {
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);
                }
                else
                {
                    if (d == 0)
                    {
                        x1 = -b / (2 * a);
                    }
                    else
                    {
                        f = true;
                        Console.WriteLine($"{a}*x^2{b1}{b}*x{c1}{c}");
                        Console.WriteLine("Нет действительных корней");
                    }
                }
            }
            else
            {
                x1 = -c / b;
            }
            if (!f)
            {
                if (a == 0 && b == 0 && c == 0)
                {
                    Console.WriteLine($"{a}*x^2{b1}{b}*x{c1}{c}");
                    Console.WriteLine("x - любое");
                }
                else
                {
                    if (a == 0 && b == 0 && c != 0)
                    {
                        Console.WriteLine($"{a}*x^2{b1}{b}*x{c1}{c}");
                        Console.WriteLine("Не имеет решений");
                    }
                    else
                    {
                        if (a == 0 && b != 0)
                        {
                            Console.WriteLine($"{a}*x^2{b1}{b}*x{c1}{c}");
                            Console.WriteLine($"{x1}");
                        }
                        else
                        {
                            if (a != 0 && d > 0)
                            {
                                Console.WriteLine($"{a}*x^2{b1}{b}*x{c1}{c}");
                                Console.WriteLine($"{x1} {x2}");
                            }
                            else
                            {
                                if (a != 0 && d == 0)
                                {
                                    Console.WriteLine($"{a}*x^2{b1}{b}*x{c1}{c}");
                                    Console.WriteLine($"{x1}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
