using System;
using System.Reflection.Metadata;
using System.Xml;

namespace CSharpBasics
{
    class Program
    {
        public static void Main()
        {
            // Switch Case
            short num = 500;
            switch (num)
            {
                case 40:
                    Console.WriteLine("Enter 40");
                    break;
                 case 30:
                    Console.WriteLine("Enter 30");
                    break;
                 case 45:
                    Console.WriteLine("Enter 45");
                    break;
                 case 50:
                    Console.WriteLine("Enter 50");
                    break;
                default:
                    System.Console.WriteLine("Default number");
                    break;

                // Новый синтаксис
                int a = 5, b = 5;
                int res = num switch
                {
                    1 => a + b,
                    2 => a - b,
                    3 => a * b,
                    4 => a / b,
                    _ => 0    
                 };

            /*
            Use the `Console` class to obtain two values ​​from the user: 
            the name of a day of the week (e.g., Monday, Tuesday...) and their age.
            Implement a `switch` statement to check the day of the week. If the day is Friday,
            include an additional check for the user's age using an `if-else` statement. 
            If the age is greater than 18, display: "You can have a drink today." 
            If it is 18 or younger, display: "Just relax today!"
            */
            // Print day
            string day = (Console.ReadLine());
            // Print age
            int age = Convert.ToInt32(Console.ReadLine());
                switch(day){
                    case "Monday":
                        Console.WriteLine("Sleep");
                        break;
                    case "Tuethday":
                        Console.WriteLine("Sleep");
                        break;
                    case "Wednesday":
                        Console.WriteLine("Sleep");
                        break;
                    case "Thursday":
                        Console.WriteLine("Sleep");
                        break;
                    case "Friday":
                        if(age >= 18)
                            Console.WriteLine("You can have a drink today.");
                        else
                            Console.WriteLine("Just relax today!");
                        break;
                    case "Saturday":
                        Console.WriteLine("Sleep");
                        break;
                    case "Sanday":
                        Console.WriteLine("Sleep");
                        break;

            }
        }
    }
}
