namespace BuyAndSellStock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine($"{s.MaxProfit(new int[] {2,1,4})} Expected: 3");
        }
    }

    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            int least = 1000000;
            int profit = 0;
            
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < least)
                {
                    least = prices[i];
                }

                int difference = prices[i] - least;

                if (difference > profit)
                {
                    profit = difference;
                }
            }
            return profit;
        }
    }
}