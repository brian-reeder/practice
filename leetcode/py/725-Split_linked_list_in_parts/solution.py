""" Solution module for leetcode problem 725-Split linked list in parts.

    Author: Brian Reeder
    Date: 07 SEP 2023
"""
from list_node import ListNode

class Solution:
    """ Solution class for leetcode problem 88-Merge Sorted Array. """
    def splitListToParts(self, head, k: int): # pylint:disable=invalid-name
        """ Split list into K parts with equal segments. 
        Adjust segment lengths based on overflow.
        """
        nums:  list(ListNode) = []
        heads: list(ListNode) = []
        walk: ListNode = head
        while walk is not None:
            nums.append(walk)
            walk: ListNode = walk.next
        width    = len(nums)//k
        overflow = len(nums)%k
        start = 0
        for _ in range(k):
            heads.append(None)
            end = start + width
            if overflow > 0:
                end = end + 1
                overflow = overflow - 1
            if end-start > 0:
                heads[-1] = nums[start]
                nums[end-1].next = None
                start = end
                continue
        return heads
