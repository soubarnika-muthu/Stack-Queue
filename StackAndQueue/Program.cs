using System;

namespace StackAndQueue
{
    //UC1 Adding Push Operation
    class Program
    {
   
        static void Main(string[] args)
        {
            Console.WriteLine("Implementation of stack and Queue");
            //creating object for stack
            Stack stack = new Stack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(53);
            stack.Display();
            Console.WriteLine("Stack is created and elements are pushed");
        }
    }
}
