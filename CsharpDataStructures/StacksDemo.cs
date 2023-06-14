using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDataStructures
{
    internal class StacksDemo
    {
        internal static void Run()
        {
            // LIFO = Last In First Out

            // stack operations: push, pop, peek, count

            Stack stack = new Stack();
            stack.Push(1);
            stack.Push("!23");
            stack.Push(true);
            stack.Push(3.14f);
            stack.Push(1.445);
            stack.Push('A');

            foreach(var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Popped element:" + stack.Pop());
            //Console.WriteLine("Popped element:" + stack.Pop());
            //Console.WriteLine("Popped element:" + stack.Pop());
            //Console.WriteLine("Popped element:" + stack.Pop());
            //Console.WriteLine("Popped element:" + stack.Pop());
            //Console.WriteLine("Popped element:" + stack.Pop());
            //Console.WriteLine("Popped element:" + stack.Pop());
            //Console.WriteLine("Popped element:" + stack.Pop()); <---- This will throw an exception because the stack is empty

            Console.WriteLine("Peeked element:" + stack.Peek()); // returns the top element without removing it
            Console.WriteLine("Peeked element:" + stack.Peek());
            Console.WriteLine("Peeked element:" + stack.Peek());

            Console.WriteLine("Element exists in Stack? " + stack.Contains(1.445));

            Console.WriteLine("Count of stack: " + stack.Count);
        }
    }
}
