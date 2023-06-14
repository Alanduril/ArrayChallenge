using System;

namespace Wyzwanie_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            GetOdd(array);
            Console.WriteLine("Even numbers:");
            GetEven(array);
        }
        public static void GetOdd(int[] Array)
        {
            foreach(int i in Array)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void GetEven(int[] Array)
        {
            foreach (int i in Array)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
