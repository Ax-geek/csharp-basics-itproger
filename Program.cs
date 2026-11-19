using System;
using System.Reflection.Metadata;
using System.Xml;

namespace CSharpBasics
{
    class Program
    {
        public static void Main()
        {
            /*
            Create a C# program that asks the user for their age.
            Using if-else conditional statements, determine the age category:
            If the age is less than 18, display the message "Children".
            If the age is between 18 and 60 (inclusive), display the message "Adults".
            If the age is greater than 60, display the message "Elderly".
            */
            Console.WriteLine("Enter age: ");
                int age = int.Parse(Console.ReadLine());

                // Checking age
                if(age < 18)
                    Console.WriteLine("Children");
                else if(age > 18 && age < 80)
                    Console.WriteLine("Adults");
                else
                    Console.WriteLine("Elderly");
        }
    }
}
