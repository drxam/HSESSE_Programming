using System.Windows.Markup;

namespace self07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            var s1 = "";
            var i = s.Length - 1;
            while (i >= 0)
            {
                s1 += s[i];
                i--;
            }
            i = 0;
            while (s1[i] == '0')
            {
                s1 = s1.Substring(1);
            }
            Console.WriteLine(s1);
        }
    }
}
