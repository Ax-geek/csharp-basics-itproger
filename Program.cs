using System;
using System.Reflection.Metadata;
using System.Xml;

namespace CSharpBasics
{
    class Program
    {
        public static void Main()
        {
            // Data array
            byte[] nums = new byte[3];
            nums[0] = 5;
            nums[1] = 15;
            nums[2] = 4;

            nums[1] = 7;
            Console.WriteLine(nums[1]++);
            string[] names = new string[] {"Bob", "Alex", "John", "Josh"};
            Console.WriteLine($"Наш первый пользователь: {names[0]}");
            
                        
        }
    }
}
