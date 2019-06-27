using System;

namespace Generics_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleStack<int> stack = new SimpleStack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(10);

            int result = stack.Pop();
            Console.WriteLine(result);
            result = stack.Pop();
            Console.WriteLine(result);
            result = stack.Peek();
            Console.WriteLine(result);
            result = stack.Peek();
            Console.WriteLine(result);
            Console.ReadLine();

        }
        class SimpleStack<T>
        {
            private class Node
            {
                public T data { get; set; }
                public Node next { get; set; }
                public Node(T data, Node next)
                {
                    this.data = data;
                    this.next = next;
                }
            }

            private Node top;
            private int count;

            public int Count { get { return count; } }

            public SimpleStack()
            {
                top = null;
                count = 0;
            }

            public void Push(T item)
            {
                top = new Node(item, top);
                count++;
            }

            public T Pop()
            {
                T result = top.data;
                top = top.next;
                count--;
                return result;
            }

            public T Peek()
            {
                return top.data;
            }

        }
    }
}
