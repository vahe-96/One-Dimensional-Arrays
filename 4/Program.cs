using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of array");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = (i + 1) * (i + 1);
            }

            Console.WriteLine("Here is your array");
            foreach (int i in arr)
            {
                Console.Write($"{i}\t");
            }
        }
    }
}
