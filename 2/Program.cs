using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = new string[7] {"29th of March","30th of March","31th of March","1st of April",
                                            "2nd of April","3rd of April","4th of April"};
            foreach (string i in days)
            {
                Console.WriteLine(i);
            }
        }
    }
}
