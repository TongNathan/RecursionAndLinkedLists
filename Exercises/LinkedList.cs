namespace Exercises
{
    public class ListNode
    {
        public string Data;
        public ListNode Next;

        public ListNode(string data, ListNode next = null)
        {
            Data = data;
            Next = null;
        }
    }

    public class LinkedList
    {
        public ListNode Head;
        public LinkedList()
        {
            Head = null;
        }

        public void AddToEnd(string newData)
        {
            ListNode newNode = new ListNode(newData, null);

            if (Head == null)
            {
                Head = newNode;
                return;
            }

            ListNode current = Head;

            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = newNode;
        }

        public ListNode GetNodeAt(int index)
        {
            int count = 0;

            if (index < 0)
            {
                return null;
            }

            ListNode current = Head;
            while (count < index)
            {
                if (current.Next != null)
                {
                    current = current.Next;
                }
                else
                {
                    return null;
                }
                count++;
            }

            return current;
        }

        public bool Find(string searchTerm)
        {
            ListNode current = Head;

            while (current != null)
            {
                if (current.Data == searchTerm)
                {
                    return true;
                }
                current = current.Next;
            }

            return false;
        }

        public int Count()
        {
            ListNode temp = Head;
            int count = 0;
            while (temp != null)
            {
                count++;
                temp = temp.Next;
            }
            return count;
        }

        public bool AddToStart(string data)
        {
            ListNode newNode = new ListNode(data);
            newNode.Next = Head;
            Head = newNode;
            return false;
        }

        public bool AddNodeAt(string data, int index)
        {
            ListNode newNode = new ListNode(data, null);
            ListNode current = Head;
            int nodeCount = 0;
            if (index < 0)
            {
                return false;
            }

            while (nodeCount < index - 1)
            {
                if (current.Next == null)
                {
                    ListNode nullNode = new ListNode(null, null);
                    current.Next = nullNode;
                }
                current = current.Next;
                nodeCount++;
            }
            newNode.Next = current.Next;
            current.Next = newNode;
            return true;
        }

        public bool DeleteNodeAt(int index)
        {
            bool remove = false;
            ListNode current = Head;
            ListNode previous = null;

            int i = 0;
            while (i < index && current != null)
            {
                previous = current;
                current = current.Next;
                i++;
            }

            if (current != null)
            {
                if (previous == null)
                {
                    Head = current.Next;
                }
                else
                {
                    previous.Next = current.Next;
                    current = null;
                }
                current = null;
                remove = true;
            }
            return remove;
        }
    }
}