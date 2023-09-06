""" Solution module for leetcode problem 88-Merge Sorted Array.

    Author: Brian Reeder
    Date: 31 AUG 2023
"""
class Solution:
    """ Solution class for leetcode problem 88-Merge Sorted Array. """
    def merge(self, nums1: list[int], m:int, nums2: list[int], n: int) -> None:
        """ Merge two sorted integer arrays in non-decreasing order. 

        Parameters
        ----------
        nums1: list[int]
            The first sorted list of integers. Contains full buffer size for nums1 + nums2.
        
        m: int
            The number of elements in the first list of integers. 
        
        nums2: list[int]
            The second sorted list of integers.
        
        n: int
            The number of elements in the first list of integers.

        Returns
        ----------
        None -- Modifies nums1 in-place
        """
        size = m+n-1
        m = m-1
        n = n-1

        for i in range(size, -1, -1):
            if m >=0 and n >=0:
                if nums1[m] >= nums2[n]:
                    nums1[i] = nums1[m]
                    m = m-1
                else:
                    nums1[i] = nums2[n]
                    n = n-1
            else:
                if m >= 0:
                    nums1[i] = nums1[m]
                    m = m-1
                else:
                    nums1[i] = nums2[n]
                    n = n-1
        return
