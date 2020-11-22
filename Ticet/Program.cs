using System;

namespace Ticet
{
    class Program
    {
        static void Hi()
        {
            Console.WriteLine("Это приложение для нахождения счастливого билетика");
        }
        static void Work()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Введите номер билета");
            Console.WriteLine("123456");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Gray;
            int num1, num2, num3, num4, num5, num6, num7, num8, num9;
            num6 = num % 10;
            num /= 10;
            num5 = num % 10;
            num /= 10;
            num4 = num % 10;
            num /= 10;
            num3 = num % 10;
            num /= 10;
            num2 = num % 10;
            num /= 10;
            num1 = num % 10;
            num7 = num1 + num2 + num3;
            num8 = num4 + num5 + num6;
            string half;
            Console.WriteLine("\n123-456\n{0}-{1}",num7, num8);
            if (num7 == num8)
            {
                half = "Счастливый билет";
            }
            else if(Math.Abs(num7 - num8) < 2)
            {
                half = "Счастливая встреча";
            }
            else
            {
                half = "Просто билет";
            }
            Console.WriteLine(half);

            num7 = num1 + num2;
            num8 = num3 + num4;
            num9 = num5 + num6;

            Console.WriteLine("12-34-56\n{0}-{1}-{2}", num7, num8, num9);
            if(num7 == num8 && num8 == num9)
            {
                half = "Счастливый билет";
            }
            else
            {
                half = "Обычный билет";
            }
            Console.WriteLine(half+"\n");
            Work();
        }
        static void Main(string[] args)
        {
            Hi();
            Work();
        }
    }
}
