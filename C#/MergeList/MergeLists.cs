	public class Solution {
	public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
		 if (list1 == null || list2 == null){
			return list1 ?? list2;
		}
		return list1.val <= list2.val 
			? new ListNode(list1.val, MergeTwoLists(list1.next, list2))
			: new ListNode(list2.val, MergeTwoLists(list1, list2.next));
        
	}
}