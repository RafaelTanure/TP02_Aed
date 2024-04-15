using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            string[] numbers = Console.ReadLine().Split(' ');
            int[] nums = new int[numbers.Length];
            for (int j = 0; j < numbers.Length; j++)
            {
                nums[j] = int.Parse(numbers[j]);
            }
            InverteVetor(nums, 0, nums.Length - 1);

            foreach (int num in nums)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
    static void InverteVetor(int[] vetor, int start, int end)
    {
        if (start >= end)
            return;

        int temp = vetor[start];
        vetor[start] = vetor[end];
        vetor[end] = temp;

        InverteVetor(vetor, start + 1, end - 1);
    }
}
