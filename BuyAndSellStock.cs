/**
Prompt:
You are given an array prices where prices[i] is the price of a given stock on the ith day.

You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.

Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.
*/

namespace BuyAndSellStock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test code.
            Solution s = new Solution();
            Console.WriteLine($"{s.MostProfit(new int[] {2,1,4})} Expected: 3");
        }
    }

    public class Solution
    {
        public int MostProfit(int[] prices)
        {
            // This is a tough problem for a first-time LeetCoder.
            // The trick is to use a 'sliding-window' algorithm.
            // To do this, we first need to keep track of our least value (currently a very large number).
            // We also need to keep track of our current profit.
            int least = 1000000;
            int profit = 0;
            
            for (int i = 0; i < prices.Length; i++)
            {
                // If we find a new lowest price, we set our Least variable to it.
                if (prices[i] < least)
                {
                    least = prices[i];
                }
                // We have a difference value where we store the difference between the current value and the least.
                int difference = prices[i] - least;
                // The final comparison -- we check if our difference is greater than our profit.
                // If it is, we update our profit.
                if (difference > profit)
                {
                    profit = difference;
                }
            }
            // We return our maximum profit.
            return profit;
        }
    }
}