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
        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Empty Stack !!");
                return;
            }
            Console.WriteLine("TOP of Stack ->" + this.top.data);
        }
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Oops ! Empty Stack.");
                return;
            }
            Console.WriteLine("Deleted Value : " + this.top.data);
            Console.WriteLine("\n");
            this.top = this.top.next;
        }
        public void IsEmpty()
        {
            while (this.top != null)
            {
                Peek();
                Pop();
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