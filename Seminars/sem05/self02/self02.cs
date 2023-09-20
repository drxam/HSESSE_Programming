namespace sem05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0, d = 0, s = 0;
            string a = Console.ReadLine();
            while (a != "0")
            {
                if (int.TryParse(a, out int z1))
                {
                    i++;
                }
                else
                {
                    if (double.TryParse(a, out double z2))
                    {
                        d++;
                    }
                    else
                    {
                        s++;
                    }
                }
                a = Console.ReadLine();
            }
            Console.WriteLine($"int = {i} double = {d} else = {s}");
        }
    }
}
