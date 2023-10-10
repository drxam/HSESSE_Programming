namespace self02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            double[] b = new double[5];
            Array.Fill_Array(a);
            Array.Print_Array(a);
            Array.Fill_Array(b, "random"); // Заполнение массива случайными числами происходит при вводе "random" вторым параметром
            Array.Print_Array(b);
        }
    }
}
