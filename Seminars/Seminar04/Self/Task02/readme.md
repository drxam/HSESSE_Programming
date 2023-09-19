Self 02. Задание 2
На основе проекта консольного приложения, подготовить программу, определяющую по имени месяца, заданного строкой в формате MonthName или ИмяМесяца (латинское или русское написание), сообщает номер этого месяца или говорит, что в году такой месяц отсутствует.
Пример диалога с программой:
January
1
Апрель 
4
HSE
В году такой месяц отсутствует.

Справка по сравнению строк: https://learn.microsoft.com/ru-ru/dotnet/api/system.string.compare?view=net-6.0 
namespace month
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result = "Такого месяца нет";
            string a = Console.ReadLine();
            switch (a)
            {
                case ("Январь" or "January"):
                    result = "1";
                    break;
                case ("Февраль" or "February"):
                    result = "2";
                    break;
                case ("Март" or "March"):
                    result = "3";
                    break;
                case ("Апрель" or "April"):
                    result = "4";
                    break;
                case ("Май" or "May"):
                    result = "5";
                    break;
                case ("Июнь" or "June"):
                    result = "6";
                    break;
                case ("Июль" or "July"):
                    result = "7";
                    break;
                case ("Август" or "August"):
                    result = "8";
                    break;
                case ("Сентябрь" or "September"):
                    result = "9";
                    break;
                case ("Октябрь" or "October"):
                    result = "10";
                    break;
                case ("Ноябрь" or "November"):
                    result = "11";
                    break;
                case ("Декабрь" or "December"):
                    result = "12";
                    break;
                default:
                    result = "Такого месяца нет";
                    break;
            }
            Console.WriteLine(result);
        }
    }
}
