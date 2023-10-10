namespace self02
{
    internal class Array
    {
        public static void Fill_Array(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
        public static void Fill_Array(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = double.Parse(Console.ReadLine());
            }
        }
        public static void Fill_Array(int[] arr, string z)
        {
            Random rnd = new Random();
            if (z == "random")
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rnd.Next();
                }
            }
        }
        public static void Fill_Array(double[] arr, string z)
        {
            Random rnd = new Random();
            if (z == "random")
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rnd.NextDouble() * 1000000000;
                }
            }
        }
        public static void Print_Array(int[] arr)
        {
            foreach (int i in arr) Console.Write(i + " ");
            Console.WriteLine();
        }
        public static void Print_Array(double[] arr)
        {
            foreach (int i in arr) Console.Write(i + " ");
            Console.WriteLine();
        }
    }
}
