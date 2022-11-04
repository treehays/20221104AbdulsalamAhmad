using System;
namespace Question1
{
    class Program
    {
        static int FinalValue(int[] num, int original)
        {
            for (int i = 0; i < num.Length; i++)
            {
                if (num.Contains(original))
                {
                    original = original * 2;
                }
            }
            return original;
        }
        public static void Main(string[] args)
        {
            // int[] num = { 5, 3, 6, 1, 12 };
            // int original = 3;
            int[] num = { 5, 3, 6, 1, 12 };
            int original = 3;
            Console.WriteLine(FinalValue(num, original));
        }
    }
}
