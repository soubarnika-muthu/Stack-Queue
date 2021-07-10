using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
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
        public StackNode top;

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
 

