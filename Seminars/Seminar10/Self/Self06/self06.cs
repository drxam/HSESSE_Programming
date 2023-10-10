using System.Diagnostics;

namespace self06
{
    internal class Program
    {
        static void Array_Remake(ref int[] arr)
        {
            int i = 0;
            while (i < arr.Length - 1)
            {
                if (Math.Abs(arr[i] + arr[i + 1]) % 3 == 0)
                {
                    arr[i] = arr[i] + arr[i + 1];
                    for (int j = i + 1; j < arr.Length - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                    Array.Resize(ref arr, arr.Length - 1);
                }
                i++;
            }
        }
        static void Array_RCount(ref int[] arr)
        {
            int k = 0;
            int s = arr.Length;

        }
        static void Main(string[] args)
        {
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                int[] a = new int[n];
                Random rnd = new Random();
                for (int i = 0; i < n; i++) a[i] = rnd.Next(-100, 101);
                Console.WriteLine("Исходный массив:");
                foreach (int i in a) Console.Write(i + " ");
                Console.WriteLine("");
                Array_Remake(ref a);
                Console.WriteLine("Измененный массив:");
                foreach (int i in a) Console.Write(i + " ");
                Console.WriteLine();
                Console.WriteLine($"Количество сжатий равно {n - a.Length}");
            }
        }
    }
}
