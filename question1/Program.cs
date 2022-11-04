using System;
namespace s3
{
    class Program
    {
        static int [] Results(int[] num, int original)
        {
            for (int i = 0; i < num.Length; i++)
            {
                if (num.Contains(original))
                {
                    original = original * 2;
                }
            }
            return num;
        }
        public static void Main(string[] args)
        {
            int[] num = { 5, 3, 6, 1, 12 };
            int original = 3;
            // int[] num = { 2,7,9};
            // int original = 4;
            Console.WriteLine(Results(num, original));
        }
    }
}
