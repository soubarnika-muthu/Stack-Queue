using System;

namespace StackAndQueue
{
    //UC1 Adding Push Operation in stack
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Implementation of stack and Queue");
            //creating object for stack
            Stack stack = new Stack();
            //creating object for queue
            Queue node = new Queue();
           /* Console.WriteLine("\n\n*********Main Menu*********\n");
             Console.WriteLine("\nChoose one option from the following list ...");
             Console.WriteLine("\n===============================================");
             Console.WriteLine("\n1.Push\n2.Pop\n3.Peek\n4.Enqueue\n");
             Console.WriteLine("\nEnter your choice?\n");
             int choice = Convert.ToInt32(Console.ReadLine());
            
                 switch (choice)
                 {
                     case 1:
                         stack.Push(70);
                         stack.Push(30);
                         stack.Push(53);
                         stack.Display();
                         Console.WriteLine("Stack is created and elements are pushed");
                         break;
                     case 2:

                         stack.Pop();
                         stack.Display();
                         break;
                     case 3:
                         stack.Peek();
                         stack.Display();
                         break;
                    case 4:
                        node.Enqueue(70);
                        node.Enqueue(30);
                        node.Enqueue(58);
                        node.display();
                        break;
                    default:
                         Console.WriteLine("Enter Valid choice");
                         break;
                 }*/
           
            stack.Push(70);
            stack.Push(30);
            stack.Push(53);
            stack.Display();
            Console.WriteLine("Stack is created and elements are pushed");
            stack.Peek();
            stack.Pop();
            stack.Peek();
            stack.Pop();
            stack.Peek();
            stack.Pop();
            stack.Peek();
            stack.Pop();
            Console.WriteLine("Queue Implementation");
           // Queue node = new Queue();
            node.Enqueue(70);
            node.Enqueue(30);
            node.Enqueue(58);
            node.display();
            node.Dequeue();
            Console.WriteLine("Queue after deleting");
            node.display();

        }
    }
}
