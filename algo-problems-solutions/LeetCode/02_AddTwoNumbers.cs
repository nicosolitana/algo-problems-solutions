namespace algo_problems_solutions.LeetCode
{
    // Problem Description : https://leetcode.com/problems/add-two-numbers/submissions/
    // Best/Average/Worst Case : O(N)

    //Definition for singly-linked list.
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null) {
            this.val = val;
            this.next = next;
        }
    }

    static class _02_AddTwoNumbers
    {
        // To determine the start and end of the linked list
        private static ListNode _head;
        private static ListNode _tail;

        // To insert value on the head of the list
        // Time Complexity is O(1)
        // Runtime does not vary since it already knows the position in the linked list
        // to add the value. With that, it operates on a constant time.
        public static ListNode insert(int data, ListNode head)
        {
            ListNode newNode = new ListNode(data, head);
            newNode.next = head;
            head = newNode;
            return head;
        }

        // To insert value at the end of the list
        // Similar with insert, its Time Complexity is O(N)
        // since it will either add value at the head or at the tail.
        public static void insertAtTail(int data)
        {
            ListNode newNode = new ListNode(data, null);
            if (_head == null)
            {
                _head = newNode;
                _tail = _head;
            }
            else
            {
                _tail.next = newNode;
                _tail = newNode;
            }
        }

        // Returns node value, but in case node is null, 0 is returned
        public static int GetNodeValue(ListNode node)
        {
            if (node == null)
                return 0;
            else
                return node.val;
        }

        // Time Complexity is O(N) where N pertains to the number of values
        // in the longest linkedlist. 
        // The approach used in this function is iterative since
        // all values in the linkedlist are needed to be visited to 
        // perform addition operation.
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            _head = null;
            int carry = 0;
            while ((l1 != null) || (l2 != null))
            {
                // Gets current digit on both first and second linkedlist
                int firstValue = GetNodeValue(l1);
                int secondValue = GetNodeValue(l2);

                // Sums the two values from the linkedlists and the carry value
                int sum = (firstValue + secondValue) + carry;

                // Gets the first digit to prepare it to store on the results linkedlist
                int value = sum % 10;

                // Store new carry value
                carry = sum / 10;

                // Insert result at the tail of the results linkedlist
                insertAtTail(value);

                // Checks if either of the list is not null
                // so next node can be retrieved
                if (l1 != null)
                    l1 = l1.next;

                if (l2 != null)
                    l2 = l2.next;
            }

            // In case there's a carry out in the last operation,
            // add this as well on the result linkedlist
            if (carry != 0)
                insertAtTail(carry);  

            // Return the head of the result linkedlist
            return _head;
        }


        public static void init()
        {
            // Test Case 1
            ListNode ll1 = null;
            ll1 = insert(9, ll1);
            ll1 = insert(9, ll1);
            ll1 = insert(9, ll1);
            ll1 = insert(9, ll1);
            ll1 = insert(9, ll1);
            ll1 = insert(9, ll1);
            ll1 = insert(9, ll1);

            ListNode ll2 = null;
            ll2 = insert(9, ll2);
            ll2 = insert(9, ll2);
            ll2 = insert(9, ll2);
            ll2 = insert(9, ll2);

            ListNode rll2  = AddTwoNumbers(ll1, ll2);
        }
    }
}
