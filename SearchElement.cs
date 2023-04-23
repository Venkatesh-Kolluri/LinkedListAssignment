using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListAssignment
{
    internal class SearchElement
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
        public void Search(int value)
        {
            Node t = head;
            bool con = false;
            while (t != null)
            {
                if (t.data.Equals(value))
                {
                    con = true;
                    Console.WriteLine("{0} is available", value);
                }
                t = t.next;
            }
            if (con == false)
            { Console.WriteLine("{0} is not available", value); }
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
