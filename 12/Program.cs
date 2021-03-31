using System;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of array");
            int n = int.Parse(Console.ReadLine());

            int[] arr1 = new int[n];
            Console.WriteLine("Enter Elements of array 1");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter element {i}");
                arr1[i] = int.Parse(Console.ReadLine());
            }

            int[] arr2 = new int[n];
            Console.WriteLine("Enter Elements of array 2");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter element {i}");
                arr2[i] = int.Parse(Console.ReadLine());
            }

            int[] arr3 = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr3[i] = arr1[i] * arr2[i];
            }

            Console.WriteLine("The elements of product array 3 are");
            foreach (int i in arr3)
            {
                Console.Write($"{i}\t");
            }
        }
    }
}
