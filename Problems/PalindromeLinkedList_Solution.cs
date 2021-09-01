namespace LeetCode.Problems
{

    public class ListNode 
    {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null) 
        {
            this.val = val;
            this.next = next;
        }
    }

    public class PalindromeLinkedList_Solution
    {
        public bool IsPalindrome(ListNode head) 
        {
            if (head == null) 
            {
                return false;
            }

            ListNode slow = head, fast = head;

            while (fast != null && fast.next != null) 
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            slow = Reverse(slow);

            fast = head;

            while (slow != null && fast != null) 
            {
                if (slow.val != fast.val) 
                {
                    return false;
                }

                slow = slow.next;
                fast = fast.next;
            }

            return true;
        }

        private ListNode Reverse(ListNode head) 
        {
            ListNode prev = null;
            ListNode cur = head;
            ListNode next;

            while (cur != null) 
            {
                next = cur.next;
                prev = cur;
                cur.next = prev;

                cur = next;
            }

            return prev;
        }
    }
}