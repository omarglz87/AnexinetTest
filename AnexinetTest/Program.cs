using System;

namespace Anexinet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get Next 20 Leap Years
            Console.WriteLine();
            Console.WriteLine("::::Get Next 20 Leap Years::::");
            int[] nextLeapYears = LeapYears.LeapYearList(2021, 20);
            Array.ForEach(nextLeapYears, Console.WriteLine);

            //Common Items
            Console.WriteLine();
            Console.WriteLine("::::Common Items::::");
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            int[] b = { 3, 2, 9, 3, 7, 11, 15, 13, 23, 27, 32, 35, 36, 37, 1 };
            int[] c = { 1, 3, 2, 5, 7, 11, 13, 15, 17, 19, 21, 23, 27, 35, 37 };
            int[] d = { 9, 17, 32, 7, 2, 3, 1, 45, 46, 47, 55, 60, 6, 17 };
            int[][] array = { a, b, c, d};
            int[] commonItems = CommonItems.CommonItemsInArrays(array);
            Array.ForEach(commonItems, Console.WriteLine);

            //Anagram
            Console.WriteLine();
            Console.WriteLine("::::ANAGRAM::::");
            bool areAnagrams = Anagram.AreAnagrams("STINGER", "ESTRNGI");
            Console.WriteLine("Are anagrams? " + areAnagrams);

            //SwapNumbers
            Console.WriteLine();
            Console.WriteLine("::::SwapNumbers::::");
            int numberA = 50, numberB = 20;
            SwapNumber.SwapNumbers(ref numberA, ref numberB);
            Console.WriteLine("numberA: " + numberA + " numberB: " + numberB);

            //Sum Numbers
            Console.WriteLine();
            Console.WriteLine("::::Sum Numbers::::");
            int numA = 15, numB = 20;
            int sum = AddNumbers.Sum(numA, numB);
            Console.WriteLine("Sum of " + numA + " + " + numB + " = " + sum);

            //TransposedMatrix
            Console.WriteLine();
            Console.WriteLine("::::TransposedMatrix::::");
            int[] x = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            int[] y = { 3, 2, 9, 3, 7, 11, 15, 13, 23, 27, 32, 35, 36, 37, 1 };
            int[] z = { 1, 3, 2, 5, 7, 11, 13, 15, 17, 19, 21, 23, 27, 35, 37 };
            int[][] matrix = { x, y, z };
            int[][] transposedMatrix = Matrix.TransposedMatrix(matrix);

            foreach(int[] arr in transposedMatrix)
            {
                foreach (int number in arr)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
