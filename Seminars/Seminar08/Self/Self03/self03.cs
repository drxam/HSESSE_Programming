namespace self03
{
    internal class Program
    {
        public static bool Shift(int shiftCount, ref char ch)
        {
            int x = (int)ch;
            if ((65 <= x && x <= 90) || (97 <= x && x <= 122) || (1040 <= x && x <= 1103))
            {
                int intch = (int)ch;
                int sh = shiftCount;
                if (97 <= intch && intch <= 122)
                {
                    int s_en_n = (((intch + sh + 7) % 26 + 97) + 7) % 26 + 97;
                    char s_en_c = Convert.ToChar(char.ConvertFromUtf32(s_en_n));
                    ch = s_en_c;
                }
                if (65 <= intch && intch <= 90)
                {
                    int s_EN_n = (((intch + sh + 13) % 26 + 65) + 13) % 26 + 65;
                    char s_EN_c = Convert.ToChar(char.ConvertFromUtf32(s_EN_n));
                    ch = s_EN_c;
                }
                if (1072 <= intch && intch <= 1103)     //без буквы ё
                {
                    int s_ru_n = (((intch + sh + 16) % 32 + 1072) + 16) % 32 + 1072;
                    char s_ru_c = Convert.ToChar(char.ConvertFromUtf32(s_ru_n));
                    ch = s_ru_c;
                }
                if (1040 <= intch && intch <= 1071)     //без буквы Ё
                {
                    int s_RU_n = (((intch + sh + 16) % 32 + 1040) + 16) % 32 + 1040;
                    char s_RU_c = Convert.ToChar(char.ConvertFromUtf32(s_RU_n));
                    ch = s_RU_c;
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ:");
            char r = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите значение сдвига:");
            int t = Convert.ToInt32(Console.ReadLine());
            Shift(t, ref r);
            Console.WriteLine($"Вывод:\n{r}");
        }
    }
}
