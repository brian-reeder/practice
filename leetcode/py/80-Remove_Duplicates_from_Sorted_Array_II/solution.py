""" Solution module for leetcode problem 80-Remove Duplicates from Sorted Array II.

    Author: Brian Reeder
    Date: 01 SEP 2023
"""
class Solution:
    """ Solution class for leetcode problem 88-Merge Sorted Array. """
    def remove_duplicates(self, nums: list[int]) -> int:
        """ Remove excess duplicates more than 2 of a distinct value.

        ### Parameters
        1. nums : list[int]
           - Sorted list of integers to be modified.

        ### Returns
        - size : int
            - New size of nums
        """
        size:int = len(nums)
        if size < 3:
            return size

        i:int = 1
        while i < size-1:
            if nums[i-1] == nums[i] and nums[i] == nums[i+1]:
                nums.pop(i)
                size = size - 1
            else:
                i = i + 1

        return size
