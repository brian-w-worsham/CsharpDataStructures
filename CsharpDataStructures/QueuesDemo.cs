using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDataStructures
{
    internal class QueuesDemo
    {
        internal static void Run() { 
            Queue queue = new Queue();

            // Enqueue (insert) elements into the queue
            // Dequeue (remove) elements from the queue

            queue.Enqueue(1);
            queue.Enqueue("testing");
            queue.Enqueue(3.14);
            queue.Enqueue("James Bond");
            queue.Enqueue(true);
            queue.Enqueue(12.123f);
            queue.Enqueue('A');


            foreach(var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Removed element: " + queue.Dequeue());
            Console.WriteLine("Peeked element: " + queue.Peek());
            Console.WriteLine("Peeked element: " + queue.Peek());
            Console.WriteLine("Queue contains? " + queue.Contains("james bond"));
            Console.WriteLine("Queue contains? " + queue.Contains("James Bond"));
            Console.WriteLine("Queue size: " + queue.Count);
        }
    }
}
