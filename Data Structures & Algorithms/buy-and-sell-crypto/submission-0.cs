public class Solution {
    public int MaxProfit(int[] prices) {
        int profit = 0;
        for(int i = 0; i < prices.Length; i++) {
            for(int j = i + 1; j < prices.Length; j++) {
                // Console.WriteLine($"{prices[i].ToString()}), {prices[j].ToString()}");
                if(prices[j] > prices[i]) {
                    Console.WriteLine($" - Found profit: {prices[j]} - {prices[i]} = {prices[j] - prices[i]}");
                    profit = Math.Max(profit, prices[j] - prices[i]);
                }
            }
        }
        return profit;
    }
}
