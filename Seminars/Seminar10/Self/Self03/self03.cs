namespace self03
{
    internal class Program
    {
        public static bool TryFindMaxElement(int[] array, out int maxValue)
        {
            if (array != null)
            {
                int ma = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    ma = Math.Max(ma, array[i]);
                }
                maxValue = ma;
                return true;
            }
            else
            {
                maxValue = 0; return false;
            }
        }
        static void Main(string[] args)
        {
            if (int.TryParse(Console.ReadLine(), out int n) && n > 1)
            {
                int[] a = new int[n];
                for (int i = 0; i < n; i++)
                {
                    a[i] = int.Parse(Console.ReadLine());
                }
                int ma = 0;
                TryFindMaxElement(a, out ma);
                Console.WriteLine($"max = {ma}");
            }
            else
            {
                Console.WriteLine("Wrong input");
            }
        }
    }
}
