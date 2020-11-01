using System;
namespace StacksandQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack !");
            Console.WriteLine("Welcome to Stack !!");
            Console.WriteLine("\n");
            Stack stack = new Stack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();
            stack.Peek();
            stack.Pop();
            stack.IsEmpty();
            stack.Display();
        }
    }
}