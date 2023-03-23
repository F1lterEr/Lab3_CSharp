using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число дня недели: ");
            int num1 = Convert.ToInt16(Console.ReadLine());
            string num11 = null;
            switch (num1)
            {
                case 1: num11 = "Monday"; 
                    break;
                case 2: num11 = "Tuesday"; 
                    break;
                case 3: num11 = "Wednesday"; 
                    break;
                case 4: num11 = "Thursday"; 
                    break;
                case 5: num11 = "Friday"; 
                    break;
                case 6: num11 = "Saturday"; 
                    break;
                case 7: num11 = "Sunday"; 
                    break;
                default: Console.WriteLine("ERROR"); 
                    break;
            }
            Console.ReadKey();

            Console.Write("Введите час (0-23): ");
            int num2 = Convert.ToInt16(Console.ReadLine());
            string num22 = null;
            switch (num2)
            {
                case 0 or <=6: num22 = "Ночь"; 
                    break;
                case 7 or <=12: num22 = "Утро"; 
                    break;
                case 13 or <= 18: num22 = "День";
                    break;
                case 19 or <= 23: num22 = "Вечер";
                    break;
            }
            Console.ReadKey();

            Console.WriteLine($"Сейчас <{num11}>, <{num22}>");
        }
    }
}
