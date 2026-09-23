# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next

class Solution:
    def mergeTwoLists(self, list1: Optional[ListNode], list2: Optional[ListNode]) -> Optional[ListNode]:

        if ((list1 == None) & (list2 == None)):
            return


        merged = []
        while list1:
            merged.append(list1.val)
            list1 = list1.next
        
        while list2:
            merged.append(list2.val)
            list2 = list2.next
        
        merged.sort()

        # Recreating Linked List
        linked = ListNode(merged[0])
        two = linked

        for i in merged[1:]:
            two.next = ListNode(i)
            two = two.next
            
        
        return linked



