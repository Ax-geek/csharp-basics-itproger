using System;

namespace CSharpBasics
{
    class Program
    {
        public static void Main()
        {
            // Обработка данных от пользователя
            // Console.WriteLine("Введите текст: ");
            // // string? user_input = Console.ReadLine();
            // int user_number = Convert.ToInt32(Console.ReadLine());
            // short number1 = Convert.ToInt16(Console.ReadLine());
            // float number2 = Convert.ToSingle(Console.ReadLine());
            // double number3 = Convert.ToDouble(Console.ReadLine());
            // bool isCorrect = Convert.ToBoolean(Console.ReadLine());
            // Console.WriteLine($"Значение: {user_number}");

            // string? some = null;

            // Альтернативные способы конвертации данных
            string? user_input = "45,5";
            float number5 = Single.Parse(user_input);
            // bool isTrue = Boolean.Parse(user_input);

            // Получение символа
            char user = Convert.ToChar(Console.Read());
            System.Console.WriteLine(user);

  



        }
    }
}
