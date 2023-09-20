namespace sem05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 51; i++)
            {
                if (i == 20) continue;
                if (i % 2 == 0 && i % 3 == 0)
                {
                    Console.WriteLine($"{i} - Число кратно 2 и 3");
                }
                else
                {
                    Console.WriteLine($"{i} - Число не соответствует условию");
                }
            }
        }
    }
}
