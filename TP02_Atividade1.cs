using System;
using System.Collections.Generic;
class Program
{
    public static void Main(string[] args)
    {
        string input;

        while ((input = Console.ReadLine()) != "0")
        {
            int n = int.Parse(input);
            bool isStack = true, isQueue = true, isList = true;
            Stack<int> stack = new Stack<int>();
            Queue<int> queue = new Queue<int>();
            List<int> list = new List<int>();

            for (int i = 0; i < n; i++)
            {
                string[] operation = Console.ReadLine().Split(' ');
                char op = operation[0][0];
                int x = int.Parse(operation[1]);

                if (op == 'I')
                {
                    stack.Push(x);
                    queue.Enqueue(x);
                    list.Add(x);
                }
                else if (op == 'R')
                {
                    if (stack.Count == 0 || stack.Pop() != x)
                        isStack = false;

                    if (queue.Count == 0 || queue.Dequeue() != x)
                        isQueue = false;

                    if (!list.Remove(x))
                        isList = false;
                }
            }

            if (isStack)
                Console.WriteLine("stack");
            else if (isQueue)
                Console.WriteLine("queue");
            else if (isList)
                Console.WriteLine("list");
        }
    }
}