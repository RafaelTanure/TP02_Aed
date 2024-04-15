using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
            string input = Console.ReadLine();
            int count = CountDiamonds(input);
            Console.WriteLine(count);
        }
    }

    static int CountDiamonds(string input)
    {
        Stack<char> stack = new Stack<char>();
        int count = 0;

        foreach (char c in input)
        {
            if (c == '<')
            {
                stack.Push(c);
            }
            else if (c == '>' && stack.Count > 0)
            {
                stack.Pop();
                count++;
            }
        }
        return count;
    }
}