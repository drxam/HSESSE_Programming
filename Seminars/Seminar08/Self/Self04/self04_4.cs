namespace self04_4
{
    internal class Program
    {
        static void TimeToHMS(int t, ref int h, ref int m, ref int s)
        {
            h = t / 3600;
            m = (t % 3600) / 60;
            s = (t % 3600) % 60;
        }
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int h = 0, m = 0, s = 0;
            TimeToHMS(t, ref h, ref m, ref s);
            Console.WriteLine($"{h} hours {m} minutes {s} seconds");
        }
    }
}
