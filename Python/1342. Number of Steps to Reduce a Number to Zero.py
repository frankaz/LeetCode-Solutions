# 1342. Number of Steps to Reduce a Number to Zero
# Level: Easy
# https://leetcode.com/problems/number-of-steps-to-reduce-a-number-to-zero/

class Solution:
    def numberOfSteps(self, num: int) -> int:
        counter = 0
        while num > 0:
            counter += 1
            if num % 2 == 0:
                num = num/2
            else:
                num -= 1
        return counter
        