using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class QueueNode
    {
        public int value;
        public QueueNode Next;
        public QueueNode(int value)
        {
            this.value = value;
            this.Next = null;
        }
    }
    class Queue
    {
        QueueNode front;
        //Enqueue method insert the node at the end of list
        public void Enqueue(int value)
        {
            QueueNode newnode = new QueueNode(value);
            if (front == null)
            {
                front = newnode;
            }
            //iterate till the last node and insert at the last
            else
            {
                QueueNode rear = front;
                while (rear.Next != null)
                {
                    rear = rear.Next;
                }
                rear.Next = newnode;
            }
        }
        public void display()
        {
            if (front == null)
            {
                Console.WriteLine("No element in stack");
            }
            else
            {
                QueueNode temp = front;
                while (temp != null)
                {
                    Console.WriteLine("{0}", temp.value);
                    temp = temp.Next;
                }
            }
        }
    }
}
