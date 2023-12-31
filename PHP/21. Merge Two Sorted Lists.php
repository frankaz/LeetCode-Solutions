<?php
// 21. Merge Two Sorted Lists
// Level: Easy
// https://leetcode.com/problems/merge-two-sorted-lists/

/**
 * Definition for a singly-linked list.
 * class ListNode {
 *     public $val = 0;
 *     public $next = null;
 *     function __construct($val = 0, $next = null) {
 *         $this->val = $val;
 *         $this->next = $next;
 *     }
 * }
 */

class Solution
{
  function mergeTwoLists($list1, $list2)
  {
    $mergedList = new ListNode();
    $tail = $mergedList;

    while ($list1 != null && $list2 != null) {
      if ($list1->val < $list2->val) {
        $tail->next = $list1;
        $list1 = $list1->next;
      } else {
        $tail->next = $list2;
        $list2 = $list2->next;
      }
      $tail = $tail->next;
    }

    $tail->next = $list1 != null ? $list1 : $list2;
    return $mergedList->next;
  }
}
