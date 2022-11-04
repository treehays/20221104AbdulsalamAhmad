using System;
namespace Lonely
{
    class Program
    {
        static int[] Results(int[] nums, int x)
        {
            List<int> arr1 = new List<int>();
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
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
            return nums;
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

/*
//n is size of array, i is counter variable
    int n, i, result;
    // ---------------------
    int arr[n];
    scanf("%d", &n);
    // ---------------------
    printf("%d\n", n);
    for(i = 0; i < n; i++){
        scanf("%d", &arr[i]);
    }
    result = lonely_integer(arr, n);
    printf("%d", result);
    return 0;
*/

/*
vector<int> findLonely(vector<int>& nums) {
    unordered_map<int, int> m;
    for (int x : nums)
      ++m[x];
    vector<int> ans;
    for (const auto [x, c] : m)
      if (c == 1 && !m.count(x + 1) && !m.count(x - 1))
        ans.push_back(x);
    return ans;
*/