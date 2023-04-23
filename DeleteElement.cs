using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListAssignment
{
    internal class DeleteElement
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
        public void Remove(int data)// 56 30 40 70
        {
            if (head == null)
            {
                Console.WriteLine("list is empty");
            }

            Node t = head, temp = null;
            bool con = false;
            while (t != null)
            {
                if (t.data.Equals(data))
                {
                    con = true;
                    temp.next = t.next;
                }
                temp = t;
                t = t.next;
            }
            if (con == false)
            {
                Console.WriteLine("Invalid Value");

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
        static void Main()
        {
            DeleteElement list = new DeleteElement();
            list.Insert(70);
            list.Insert(40);
            list.Insert(30);
            list.Insert(56);
            list.Remove(40);
            list.Print();


        }

    }
}
