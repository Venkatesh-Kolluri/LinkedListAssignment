using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListAssignment
{
    public class InsertList
    {
        Node head;
        public class Node
        {
            public int data;
            public Node next;
            public Node(int data)
            {
                this.data = data;
            }
        }

        public void Insert(int data)
        {
            Node n = new Node(data);
            if (head == null)
            {
                head = n;
            }
            else
            {
                n.next = head;
                head = n;
            }
        }
        public void Print()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }

    }
}
