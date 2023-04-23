using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedListAssignment
{
    internal class InsertBetween
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
        public void Insert(int data)  // 56 30 70
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
        public void InBetween(int data, int key)
        {
            Node t = head;
            Node n = new Node(data);
            while (t != null)
            {
                if (t.data.Equals(key))
                {
                    n.next = t.next;
                    t.next = n;
                }
                t = t.next;
            }
        }
        public void Print()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }

    }
}

