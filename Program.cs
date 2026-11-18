using System;

namespace CSharpBasics
{
    class Program
    {
        public static void Main()
        {
            //Обработка данных от пользователя
            Console.WriteLine("Введите текст: ");
            // string? user_input = Console.ReadLine();
            int user_number = Convert.ToInt32(Console.ReadLine());
            short number1 = Convert.ToInt16(Console.ReadLine());
            float number2 = Convert.ToSingle(Console.ReadLine());
            double number3 = Convert.ToDouble(Console.ReadLine());
            bool isCorrect = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine($"Значение: {user_number}");

            string? some = null;

            //Альтернативные способы конвертации данных
            string? user_input = "45,5";
            float number5 = Single.Parse(user_input);
            // bool isTrue = Boolean.Parse(user_input);

            // Получение символа
            char user = Convert.ToChar(Console.Read());
            System.Console.WriteLine(user);

            System.Console.WriteLine("Enter float: ");
            float user_num1, user_num2, result;
            user_num1 = Convert.ToSingle(Console.ReadLine());
            user_num2 = Convert.ToSingle(Console.ReadLine());

            result = user_num1 + user_num2;
            System.Console.WriteLine($"Добавление: {result.ToString()}");
            result = user_num1 + user_num2;
            System.Console.WriteLine($"Результат: {result.ToString()}");
            result = user_num1 - user_num2;
            System.Console.WriteLine($"Результат: {result.ToString()}");
            result = user_num1 * user_num2;
            System.Console.WriteLine($"Результат: {result.ToString()}");
            result = user_num1 / user_num2;
            System.Console.WriteLine($"Результат: {result.ToString()}");
            result = user_num1 % user_num2;
            System.Console.WriteLine($"Результат: {result.ToString()}");
            
            // Сокращенные действия

            int num = 500;
            num += 50;
            num++;
            num--;
            System.Console.WriteLine(num);

            // Класс Math
            System.Console.WriteLine(Math.PI);
            System.Console.WriteLine(Math.E);
            System.Console.WriteLine(Math.Abs(-4));
            System.Console.WriteLine(Math.Floor(4.99f));
            System.Console.WriteLine(Math.Ceiling(4.01f));
            System.Console.WriteLine(Math.Round(4.56f));
            System.Console.WriteLine(Math.Pow(4,5));
            System.Console.WriteLine(Math.Min(5,7));
            System.Console.WriteLine(Math.Max(4,5));

            // Площадь треугольника
            float a, b, beta;
            System.Console.Write("Enter a: ");
            a = Convert.ToSingle(Console.ReadLine());
            System.Console.Write("Enter b: ");
            b = Convert.ToSingle(Console.ReadLine());
            System.Console.Write("Enter beta: ");
            beta = Convert.ToSingle(Console.ReadLine());

           double res = 0.5f * a * b * Math.Sin(beta);
           System.Console.WriteLine($"Результат: {res}");









        }
    }
}
