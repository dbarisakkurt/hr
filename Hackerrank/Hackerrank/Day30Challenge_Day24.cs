using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank
{
    class Node
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }

    }
    class Solution
    {

        public static Node removeDuplicates(Node head)
        {
            if (head == null || head.next == null)
                return head;

            List<int> items = new List<int>();
            Node scan = head;
            Node previous = head;

            while (scan != null)
            {
                //remove duplicate
                if (scan != null && items.Contains(scan.data))
                {
                    Node tempPrevious = null;
                    while (scan != null && items.Contains(scan.data))
                    {
                        tempPrevious = scan;
                        scan = scan.next;
                    }
                    previous.next = scan;
                }
                else
                {
                    items.Add(scan.data);
                    previous = scan;
                    scan = scan.next;

                }
            }

            return head;
        }
        public static Node insert(Node head, int data)
        {
            Node p = new Node(data);


            if (head == null)
                head = p;
            else if (head.next == null)
                head.next = p;
            else
            {
                Node start = head;
                while (start.next != null)
                    start = start.next;
                start.next = p;

            }
            return head;
        }
        public static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }
        public static void MainDay()
        {
            int[] data = { 1, 2, 2, 3, 3, 4 };
            Node head = null;
            for (int i = 0; i < data.Length; i++)
            {

                head = insert(head, data[i]);
            }
            head = removeDuplicates(head);
            display(head);
        }
    }
}
