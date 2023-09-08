""" Standard implementation of the Linked List Node """
from __future__ import annotations
from typing import TypeVar

T = TypeVar("T")

class ListNode: # pylint:disable=too-few-public-methods
    """ Standard implementation of the Linked List Node class """
    val: any
    next: ListNode

    def __init__(self, val=0, next=None): # pylint:disable=redefined-builtin
        self.val = val
        self.next = next
