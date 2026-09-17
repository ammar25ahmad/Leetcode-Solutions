class Solution:
    def isPalindrome(self, x: int) -> bool:
        num = str(x)
        reversed = num[::-1]
        return reversed == num