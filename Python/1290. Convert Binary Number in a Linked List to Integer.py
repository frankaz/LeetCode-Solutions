# 1290. Convert Binary Number in a Linked List to Integer
# Level: Easy
# https://leetcode.com/problems/convert-binary-number-in-a-linked-list-to-integer/

# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next

class Solution:
    def getDecimalValue(self, head: ListNode) -> int:
        strBuilder = ""
        while head:
            strBuilder += str(head.val)
            head = head.next

        return int(strBuilder, 2)
        