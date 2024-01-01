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
public class Solution
{
    public ListNode MergeKLists(ListNode[] lists)
    {
      if (lists == null)
        return null;
      ListNode tempList = new ListNode(int.MinValue);
      for (int i = 0; i < lists.Length; i++)
        tempList = MergeTwoLists(tempList, lists[i]);
      return tempList.next;
    }

    private ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
      ListNode tempList = new ListNode(0);
      ListNode cur = tempList;

      while (list1 != null && list2 != null)
      {
        if (list1.val < list2.val)
        {
          cur.next = list1;
          list1 = list1.next;
        }
        else
        {
          cur.next = list2;
          list2 = list2.next;
        }
        cur = cur.next;
      }

      if (list1 != null)
        cur.next = list1;
      else if (list2 != null)
        cur.next = list2;
      return tempList.next;
    }
}

