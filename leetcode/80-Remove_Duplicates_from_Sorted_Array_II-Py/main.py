""" Test runner for solution to leetcode problem 80-Remove Duplicates from Sorted Array II

Author: Brian Reeder
Date: 01 SEP 2023
"""
from solution import Solution

if __name__ == "__main__":
    TESTCASES = [
        {'nums':[1,1,1,2,2,3],'ans_nums':[1,1,2,2,3], 'ans_k':5},
        {'nums':[1,1,1,1,1,1],'ans_nums':[1,1], 'ans_k':2},
        {'nums':[1,1,1,1,1,2],'ans_nums':[1,1,2], 'ans_k':3},
    ]
    solve = Solution()
    for test in TESTCASES:
        x_nums = test['nums'].copy()
        x_k = solve.remove_duplicates(x_nums)
        try:
            assert x_k == test['ans_k']
            assert x_nums == test['ans_nums']
        except AssertionError:
            print(
                f"remove_duplicates({test['nums']}) -> {x_nums}/{x_k}"\
                f"but expected {test['ans_nums']}/{test['ans_k']}"
            )
