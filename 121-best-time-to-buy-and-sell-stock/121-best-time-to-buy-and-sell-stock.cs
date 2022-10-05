public class Solution {
   public int MaxProfit(int[] prices) {
        int min = prices[0];
        int maxProfit = 0;
        
        for(int i=1; i < prices.Length; i++)
        {
            if(prices[i] < min)
            {
                min = prices[i];
            }
            else if(prices[i] - min > maxProfit)
            {
                maxProfit = prices[i] - min;
            }
        }
        return maxProfit;
    }
}