class Solution:
    def reverse(self, x: int) -> int:
        sign = 1
        if x<0:
            sign = -1
        abs_of_x = abs(x)
        strNum = str(abs_of_x)
        reverseNum = strNum[::-1]
        finalAns = int(reverseNum) * sign
        if finalAns < -2**31 or finalAns > 2**31 - 1:
            return 0
        return finalAns
