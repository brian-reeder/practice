""" My python implementation for a Binary Search """
from typing import TypeVar

T = TypeVar('T')
def binary_search(sorted_list: list[T], target: T) -> int:
    """Perform a Binary Search and return the index of the target."""
    left = 0
    right = len(sorted_list)-1
    while left <= right:
        mid = left+((right-left)//2)
        if sorted_list[mid] == target:
            return mid
        if sorted_list[mid] > target:
            right = mid-1
        if sorted_list[mid] < target:
            left = mid+1
    return -1

if __name__ == '__main__':
    TESTCASES = [
        [0, 1, 2, 3, 4, 5, 6, 7, 8, 9],
        [0.0, 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7],
        ['a','b','c','d','e','f','g','h','i'],
    ]
    for test in TESTCASES:
        for i,elem in enumerate(test):
            try:
                x = binary_search(test, elem)
                assert x == i
            except AssertionError:
                print(f"ERROR: binary_search({test}, {elem})-> {x} but expected {i}")
