namespace self04
{
    internal class Program
    {
        static void FillArrayKeyboard(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        static void FillArrayRandom(int[,] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(-100, 101);
                }
            }
        }
        static void PrintArray(int[,] arr, int[] v)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int j = 0; j < arr.GetLength(1); j++)
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    v[j] += arr[i, j];
                }
            }
        }
        static void PrintVector(int[] v)
        {
            Console.WriteLine();
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] a = new int[n, m];
            int[] v = new int[m];
            Console.WriteLine("Выбор способа заполнения массива:\n1 - заполнение случайными числами\t2 - заполнение с клавиатуры");
            int t = int.Parse(Console.ReadLine());
            if (t == 1)
            {
                FillArrayRandom(a);
            }
            else
            {
                if (t == 2)
                {
                    FillArrayKeyboard(a);
                }
                else
                {
                    Console.WriteLine("Неверный ввод");
                }
            }
            PrintArray(a, v);
            PrintVector(v);
        }
    }
}
