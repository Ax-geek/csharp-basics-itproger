using System;

namespace CSharpBasics
{
    class Program
    {
        public static void Main()
        {
            // Переменные
            int number = 40;
            Console.WriteLine($"Переменная: {number}");
            number = 45;
            Console.WriteLine(number);
            int num2 = 15;
            Console.WriteLine(num2);
            System.Console.WriteLine($"Переменные: {number},{num2 + 65}");

            // Типы данных
            // byte: 0 до 255
            // short: - 32 768 до 32 767
            // ushort: 0 до 65 535
            // int: - 2 147 483 648 до 2 147 483 647
            // uint: 0 до 4294967294
            // long: - 9 223 372 036 854 775 808 до 9 223 372 036 854 775 807

            // Целые числа
            byte num1 = 250;

            short num3 = - 10;
            ushort num4 = 65400;

            int num5 = -3435454;
            uint num6 = 3435454;

            long num7 = 35498745333334;

            // Числа с точкой
            float numb1 = 958456985.4569468406f; // 32-разрядное 
            double numb2 = 3528034752357.57237589734573857d; // 64-разрядное

            // Символы и строки
            char symbol = 'x';
            string word = "Hello world";
            
            // Bool
            bool isHasAnimal = false;

            int num10 = 5, num11 = 7;

            // Константы
            const int NMBER1 = 6;

            var some_new = 2;
            dynamic some_new2 = 3;
            


        }
    }
}
