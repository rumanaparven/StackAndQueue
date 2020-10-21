using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    class LinkedListQueue
    {

        Node head = null;
        internal void Enqueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine(node.data + " is inserted into the queue");
        }
    }   
}
