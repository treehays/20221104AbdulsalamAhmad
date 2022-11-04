using System;
namespace Lonely
{
    class Program
    {
        static int[] Results(int[] nums, int x)
        {
            List<int> arr1 = new List<int>();
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] != nums[i + 1] && (nums[i] + 1) != nums[i + 1]) //check forward
                {
                    if (i > 0)
                    {
                        // check backward
                        if ((nums[i] - 1) != nums[i - 1])
                        {
                            arr1.Add(nums[i]);
                        }
                    }
                    // break;
                }
            }
            foreach (var item in arr1.ToArray())
            {
                Console.WriteLine(item);
            }
            return arr1.ToArray();
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
