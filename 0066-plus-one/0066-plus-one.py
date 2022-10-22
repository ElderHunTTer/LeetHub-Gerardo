class Solution:
    def plusOne(self, digits: List[int]) -> List[int]:

        if digits[-1] < 9: # we just need to add 1 to the last position if it is less than 9
            digits[-1] += 1
            return digits

        for i in range(len(digits)-1, -1, -1): # iterate from last to first position
            if digits[i] + 1 < 10: # if we are able to add 1 already, return early
                digits[i] += 1
                return digits
            else:
                digits[i] = 0 # otherwise, make it zero and wait for the next opportunity

        if digits[0] == 0:
            digits.insert(0, 1)

        return digits