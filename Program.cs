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
            Console.WriteLine(++nums[1]);
            string[] names = new string[] {"Bob", "Alex", "John", "Josh"};
            Console.WriteLine($"Наш первый пользователь: {names[^1]}");

            // Multidimensional arrays
            // byte[,] numbers = new byte[3, 2];
            byte[,] numbers =
            {
                {4 ,5},
                {5, 6},
                {6, 7}
            };
            numbers[1, 1] = 56;
            Console.WriteLine(numbers[1, 1]);

            // bite[,,] nums3 = new byte[3,3,3];
            bite[,,] nums3 = {
                {
                    {3, 5},
                    {5, 7}
                },
                {
                    {3, 5},
                    {5, 7}
                },
                {
                    {3, 5},
                    {5, 7}
                }
            };
            nums3[1, 0, 1] = 45;


            short[][] nums1 = new short[3][];
            nums1[0] = new short[2];
            nums1[1] = new short[3];
            nums1[2] = new short[6];
            nums1[0][0] = 56;
            Console.WriteLine(++nums1[0][0]);

            int[][] num2 = 
            { 
                new int[]{4, 5}, 
                new int[]{5, 6, 0},
                new int[]{6, 7, 5, 6, 7, 7},
                new int[]{3}
                };

                nums2[^2][^2] = 5;



                        
        }
    }
}
