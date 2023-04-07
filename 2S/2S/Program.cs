namespace _2S
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution test1 = new Solution();
            int[] first = test1.TwoSum(new int[] { 2, 7, 11, 15}, 9);
            int[] second = test1.TwoSum(new int[] { 3, 2, 4 }, 6);

            foreach (var item in first)
            {
                Console.Write(item.ToString());
            }

            Console.WriteLine();

            foreach (var item in second)
            {
                Console.Write(item.ToString());
            }
        }
    }

    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int e = nums[i];
                for (int j = 0; j < nums.Length; j++)
                {
                    if (j == i) 
                    {
                        continue;
                    }
                  
                    else if (nums[j] + e == target)
                    {
                        int[] result = new int[] { i, j };
                        return result;
                    }
                }
            }
            return nums;
        }
    }
}