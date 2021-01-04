using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms
{
    public class Recursion_Fibonacci
    {
        public Recursion_Fibonacci()
        {

        }

        public void FibonacciIterative(int index)
        {
            int[] arr = new int[index + 1];
            arr[0] = 0;
            arr[1] = 1;

            if(index == 0)
            {
                Console.WriteLine(arr[0]);
                return;
            }

            else if(index == 1)
            {
                Console.WriteLine(arr[1]);
                return;
            }

            for(int i = 2; i <= index; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }

            Console.WriteLine(arr[index]);
        }

        public int FibonacciRecursive(int index)
        {
            // O(2^N)
            if(index < 2)
            {
                return index;
            }

            return FibonacciRecursive(index - 1) + FibonacciRecursive(index - 2);
        }
    }
}
