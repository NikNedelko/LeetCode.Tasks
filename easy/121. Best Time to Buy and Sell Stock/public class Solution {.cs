public class Solution {
    public int MaxProfit(int[] prices) {
        if(prices.Length==1)
            return 0;
        int maxSum = prices[1]-prices[0];
        int current=prices[0];
        
        for(int i = 0; i<prices.Length;i++){
            if(prices[i]<current)
                current = prices[i];
            if(prices[i]-current>maxSum)
                maxSum = prices[i]-current;
        }
        if(maxSum<0)
            return 0;
        return maxSum;
    }
}