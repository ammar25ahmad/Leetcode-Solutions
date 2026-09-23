class Solution:
    def mySqrt(self, x: int) -> int:
        left = 0
        right = x
        finalAns = 0
        
        while left <= right:
            midPoint = left + ((right - left) // 2)
            
            if midPoint * midPoint > x:
                right = midPoint - 1
            elif midPoint * midPoint < x:
                left = midPoint + 1
                finalAns = midPoint
            else:
                return midPoint
                
        return finalAns
