/**
Prompt:
Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.
*/

namespace _2S
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test code for our solution.
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
            // Iterate through the list of numbers -- brute force method.
            for (int i = 0; i < nums.Length; i++)
            {
                int e = nums[i];
                for (int j = 0; j < nums.Length; j++)
                {
                    if (j == i) 
                    {
                        continue;
                    }
                    // Check if the two numbers add up to the target. If they do, we return the result.
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