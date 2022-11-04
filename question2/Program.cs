using System;
namespace Lonely
{
    class Program
    {
        static int FinalValue(int[] num, int x)
        {
            for (int i = 0; i < num.Length; i++)
            {
                if (num.Contains(x))
                {
                    x = x * 2;
                }
            }
            return x;
        }
        public static void Main(string[] args)
        {
            int[] num = { 5, 3, 6, 1, 12 };
            int x = 3;
            // int[] num = { 2,7,9};
            // int original = 4;
            Console.WriteLine(FinalValue(num, x));
        }

    }

}