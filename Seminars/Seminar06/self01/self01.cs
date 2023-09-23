namespace sem06dz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool p = false, q = false;
            do
            {
                do
                {
                    Console.WriteLine($"p = {p, 5} q = {q,5} F = {!(p && q) && !(p || !q),5}");
                    q = !q;
                } while (q);
                p = !p;
            } while (p);
        }
    }
}
