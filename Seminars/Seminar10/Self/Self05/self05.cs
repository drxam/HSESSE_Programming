namespace self05
{
    internal class Program
    {
        static int[] Arr_Del(ref int[] a)
        {
            int k = a.Count(x  => x < 0);
            int k1 = a.Count(x => x >= 0);
            int[] arr = new int[k];
            int[] arr1 = new int[k1];
            k = 0;
            k1 = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < 0)
                {
                    arr[k++] = a[i];
                }
                else
                {
                    arr1[k1++] = a[i];
                }
            }
            a = arr1;
            return arr;
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                int[] a = new int[n];
                for (int i = 0; i < n; i++)
                {
                    a[i] = rnd.Next(-100, 101);
                }
                int[] b = new int[0];
                Console.WriteLine("Исходный массив:");
                foreach (int i in a) Console.Write(i + " ");
                Console.WriteLine();

                b = Arr_Del(ref a);

                Console.WriteLine("Измененный массив:");
                foreach (int i in a) Console.Write(i + " ");
                Console.WriteLine();
                Console.WriteLine("Массив отрицательных элементов:");
                foreach (int i in b) Console.Write(i + " ");
            }
            else
            {
                Console.WriteLine("Wrong input");
            }
        }
    }
}
