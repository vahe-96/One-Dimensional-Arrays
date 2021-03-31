using System;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of array");
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter element {i}");
                arr1[i] = int.Parse(Console.ReadLine());
            }

            int[] arr2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr2[i] = arr1[i];
            }

            Console.WriteLine("The elements of second array are");
            foreach (int i in arr2)
            {
                Console.Write($"{i}\t");
            }
        }
    }
}
