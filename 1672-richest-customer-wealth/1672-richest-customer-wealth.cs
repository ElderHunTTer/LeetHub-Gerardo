public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int maxWealthSoFar = 0;
        
        for(int i = 0; i < accounts.Length; i++) {
            int currentCustomerWealth = 0;
            
            for(int j = 0; j < accounts[i].Length; j++){
                currentCustomerWealth += accounts[i][j];
            }
            
            maxWealthSoFar = Math.Max(maxWealthSoFar, currentCustomerWealth);
        }
        
        return maxWealthSoFar;
    }
}