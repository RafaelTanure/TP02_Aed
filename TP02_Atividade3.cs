using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            string[] input = Console.ReadLine().Split();
            int num1 = int.Parse(input[0]);
            int num2 = int.Parse(input[1]);

            int mdc = CalcularMDC(num1, num2);

            Console.WriteLine(mdc);
        }
    }

    static int CalcularMDC(int x, int y)
    {
        if (x == y)
            return x;

        if (x > y)
            return CalcularMDC(x - y, y);
        else
            return CalcularMDC(x, y - x);
    }
}



