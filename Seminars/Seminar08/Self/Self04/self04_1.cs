namespace self04
{
    internal class Program
    {
        static void SummIt(double A, double B, out int k, out int s)
        {
            k = 0;
            s = 0;
            int a = (A == (int)Math.Floor(A)) ? (int)Math.Floor(A) : (int)Math.Floor(A) + 1;
            int b = (int)Math.Floor(B);
            for (int i = a; i <= b; i++)
            {
                string st = i.ToString();
                if (st.Count(x => x == '1') > 0)
                {
                    k++;
                    s += i;
                }
            }
        }
        static void TotalSumm(double A, double B, out int s)
        {
            s = 0;
            int a = (A == (int)Math.Floor(A)) ? (int)Math.Floor(A) : (int)Math.Floor(A) + 1;
            int b = (int)Math.Floor(B);
            for (int i = a; i <= b; i++)
            {
                s += i;
            }
        }
        static void Main(string[] args)
        {
            int k1 = 0, s1 = 0, s2 = 0;
            double start = double.Parse(Console.ReadLine());
            double end = double.Parse(Console.ReadLine());
            SummIt(start, end, out  k1, out s1);
            TotalSumm(start, end, out s2);
            Console.WriteLine(Math.Abs(s2 - s1));
        }
    }
}
