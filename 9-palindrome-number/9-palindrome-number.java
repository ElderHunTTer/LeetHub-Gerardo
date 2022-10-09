class Solution {
    public boolean isPalindrome(int x) {
        String xAsString = String.valueOf(x);   
        int opposingIndex = xAsString.length();
        for (int i = 0; i < opposingIndex; i++) {
            if (xAsString.charAt(i) != xAsString.charAt(--opposingIndex)) {
                return false;
            }
        }
        return true;
    }
}