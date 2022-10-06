class Solution:
    # def isPalindrome(self, s: str) -> bool:
    #     s = re.sub(r'[^a-zA-Z]', '', s).lower() # Remove all non letters and lowercase them
    #     for x in range(len(s)//2): # Integer divide to get the half
    #         if s[x] is not s[-x-1]: # Compare x letter from the front and x letter from the back
    #             return False
    #     return True # If they get this far its valid (0 and 1 length strings are also valid)
    def isPalindrome(self, s: str) -> bool:
        s = ''.join([a.lower() for a in s if a.isalnum()])
        return True if s[::-1] == s else False