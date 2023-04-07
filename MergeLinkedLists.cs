/**
Prompt:

You are given the heads of two sorted linked lists list1 and list2.

Merge the two lists in a one sorted list. The list should be made by splicing together the nodes of the first two lists.

Return the head of the merged linked list.
*/

namespace MergeLinkedLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test code is not all the way completed here because to do so would make the code look messy.
            // If you want to test this solution, add in your Lists below and define an iter function.
            Solution s = new();
            // Add your Lists here, using ListNode
            ListNode newlist = s.MergeTwoLists();
            // Print the List using your iter function.
        }
    }

    public class ListNode {
        // The provided definition for a list node.
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
    }
 
    public class Solution
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {   
            // Because these are linked lists, we want to solve this recursively.
            // Our base case: If either list is null, we return the other list.    
            if (list1 == null)
            {
                return list2;
            }
            else if (list2 == null) {
                return list1;
            }
            
            // It doesn't say it in the prompt, but we want to sort this in ascending order.
            // That means we need to check if one node is smaller than the other, and add the smaller one.
            if (list1.val < list2.val)
            {
                // If the value on our first list is smaller,
                // we set our next node equal to a recursive function call on itself and on the node we just compared with.
                // This ensures that we prefer the smaller nodes.
                list1.next = MergeTwoLists(list1.next, list2);
                // The first node of list1 is smaller, so we return the head of that node.
                return list1;
            }
            else
            {
                // This is what we do if the other node at the beginning is smaller.
                list2.next = MergeTwoLists(list2.next, list1);
                return list2;
            }
        }
    }
}