public class Solution
{
    public ListNode ReverseList(ListNode head)
    {

        if (head is null)
            return null;

        ListNode tail = null, next;

        while (head != null)
        {
            next = head.next;
            head.next = tail;
            tail = head;
            head = next;
        }

        return tail;

    }
}