using System;
using System.Collections.Generic;
using System.Text;
namespace StacksandQueues
{
    public class Queue
    {
        Node head = null;
        public void Enqueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
                head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                    temp = temp.next;
                temp.next = node;
            }
        }
        public void Dequeue()
        {
            if (head == null)
                Console.WriteLine("Empty Queue !!");
            else
                head = head.next;
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Empty Queue !!");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data);
                if (temp.next != null)
                    Console.Write("-> ");
                temp = temp.next;
            }
            Console.WriteLine("\n");
        }
    }
}