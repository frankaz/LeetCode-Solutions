// 1290. Convert Binary Number in a Linked List to Integer
// Level: Easy
// https://leetcode.com/problems/convert-binary-number-in-a-linked-list-to-integer/

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution
{
  public int GetDecimalValue(ListNode head)
  {
    StringBuilder str = new StringBuilder();

    while (head != null)
    {
      str.Append(head.val.ToString());
      head = head.next;
    }
    return Convert.ToInt32(str.ToString(), 2);
  }
}