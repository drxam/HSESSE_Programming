namespace self02
{
    internal class Program
    {
        static int F(bool a)
        {
            int b = Convert.ToInt32(a);
            return b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("F = !(a || b && c) || a");
            Console.WriteLine("A B C F");
            bool a = false, b = false, c = false;
            do
            {
                do
                {
                    do
                    {
                        Console.WriteLine($"{F(a)} {F(b)} {F(c)} {F(!(a || b && c) || a)}");
                        c = !c;
                    } while (c);
                    b = !b;
                } while (b);
                a = !a;
            } while (a);
        }
    }
}
