namespace sem10
{
    internal class Program
    {
        static void Fill_Array(double[] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = -12.25 + rnd.NextDouble() * 24.5;
            }
        }
        static void Print_Array(double[] arr)
        {
            foreach (int i in arr) Console.Write(i + " ");
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] a = new double[n];
            Fill_Array(a);
            Print_Array(a);
        }
    }
}
