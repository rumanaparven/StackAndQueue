using System;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListStack stack = new LinkedListStack();
            stack.Push(10);
            stack.Push(20);
            stack.Push(45);
            stack.Push(67);
            stack.PeekAndPopUntilStackIsEmpty();
            LinkedListQueue queue = new LinkedListQueue();
            queue.Enqueue(20);
            queue.Enqueue(55);
            queue.Enqueue(76);
            queue.Dequeue();
            
        }
    }
}
