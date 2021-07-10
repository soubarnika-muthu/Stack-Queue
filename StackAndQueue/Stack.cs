using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    //Creating a NewNode
    public class StackNode
    {
        public int value;
        public StackNode Next;
        public StackNode(int value)
        {
            this.value = value;
            this.Next = null;
        }
    }
    class Stack
    {
        //Top Node
        public StackNode top;

        //Method to push elements into the stack
        public void Push(int value)
        {
            StackNode newNode = new StackNode(value);
            if (top == null)
            {
                top = newNode;
            }
            else
            {
                newNode.Next = top;
                top = newNode;
            }
        }
        //remove the element from stack
        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("No element to pop");
                return;
            }
            Console.WriteLine("The Poped element is {0}", top.value);
            top = top.Next;
           
        }
        //returns the top element of the stack
        public void Peek()
        {
            if (top == null)
            {
                Console.WriteLine("No element to peek");
                return;
            }
            Console.WriteLine("the top element is {0}", top.value);
        }
        //method to display the elements in the stack
        public void Display()
        {
            StackNode temp = this.top;
            if(top==null)
            {
                Console.WriteLine("No elements in the Stack ");
            }
           while(temp!=null)
            {
                Console.WriteLine("Value in the Stack:"+temp.value);
                temp = temp.Next;
            }
        }

    }

}
 

