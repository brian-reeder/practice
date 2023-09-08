""" Test runner for solution to leetcode problem 725-Split linked list in parts

Author: Brian Reeder
Date: 07 SEP 2023
"""
from list_node import ListNode
from solution import Solution

if __name__ == "__main__":
    TESTCASES = [
        {'head':[1,2,3],'k':5,'ans':[[1],[2],[3],[],[]]},
        {'head':[1,2,3,4,5,6,7,8,9,10,11,12,13],'k':4,'ans':[[1,2,3,4],[5,6,7],[8,9,10],[11,12,13]]},
    ]
    solve = Solution()
    for test in TESTCASES:
        head: ListNode = None
        for e in (test['head'])[::-1]:
            head = ListNode(e, head)

        x = solve.splitListToParts(head, test['k'])
        x_list = []
        for e in x:
            w = e
            L = []
            while w is not None:
                L.append(w.val)
                w = w.next
            x_list.append(L)
        print(x_list)
        try:
            assert test['ans'] == x_list
        except AssertionError:
            print(x_list)
            print("Uh-Oh")
        print("-----")
        #print(test)
