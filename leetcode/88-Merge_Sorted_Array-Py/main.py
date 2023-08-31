""" Test runner for solution to leetcode problem 88-Merge Sorted Array

Author: Brian Reeder
Date: 31 AUG 2023
"""
from solution import Solution

if __name__ == "__main__":
    TESTCASES = [
        {'nums1':[1,2,3,0,0,0],'m':3,'nums2':[2,5,6],'n':3},
        {'nums1':[1],'m':1,'nums2':[],'n':0},
        {'nums1':[0],'m':0,'nums2':[1],'n':1},
        {'nums1':[1,2,3,0,0,0,0],'m':3,'nums2':[2,2,5,6],'n':4},
    ]
    solve = Solution()
    for test in TESTCASES:
        try:
            assert len(test['nums2']) == test['n']
        except AssertionError:
            print(f"ERROR: len(nums2) and n mismatch. {test['nums2']} -> {test['n']}")
            continue
        try:
            assert len(test['nums1']) == test['m'] + test['n']
        except AssertionError:
            print("ERROR: len(nums1) and m+n mismatch. "\
                  f"{test['nums1']} -> {test['m']} + {test['n']}")
            continue
        solve.merge(**test)
        print(test)
