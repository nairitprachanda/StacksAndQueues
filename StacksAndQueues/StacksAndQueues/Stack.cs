using System;
using System.Collections.Generic;
using System.Text;

namespace StacksandQueues
{
    public class Stack
    {
        private Node top;
        public Stack()
        {
            this.top = null;
        }
        public void Push(int data)
        {
            Node node = new Node(data);
            if (top == null)
                top = node;
            else
            {
                node.next = top;
                top = node;
            }
        }
        public void Display()
        {
            if (top == null)
            {
                Console.WriteLine("Empty Stack !!");
            }
            else
            {
                Node temp = top;
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
}