""" My python implementation for a Bubble Sort """
from typing import TypeVar

T = TypeVar('T')
def bubble_sort(unsorted_list: list[T]) -> None:
    """Perform a Bubble Sort to sort a list of elements."""
    for j in range(len(unsorted_list)-1, 0, -1):
        for i in range(j):
            elem1 = unsorted_list[i]
            elem2 = unsorted_list[i+1]
            if elem1 > elem2:
                unsorted_list[i], unsorted_list[i+1] = elem1,elem2

if __name__ == '__main__':
    x = [4,3,2,1,9,8,7,6,5]
    print(x)
    bubble_sort(x)
    print(x)
