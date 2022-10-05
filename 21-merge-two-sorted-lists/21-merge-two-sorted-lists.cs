/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        return MergeRec(list1, list2);
    }
    
    private ListNode MergeRec(ListNode n1, ListNode n2)
    {
        if(n1 == null || n2 == null)
            return n1 == null ? n2 : n1;
        
        if(n1.val < n2.val)
        {
            n1.next = MergeRec(n1.next, n2);
            return n1;
        } 
        else
        {
            n2.next = MergeRec(n1, n2.next);
            return n2;
        }
    }
}