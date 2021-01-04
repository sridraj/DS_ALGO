using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms
{
    public class Recursion_Factorial
    {
        public Recursion_Factorial()
        {

        }

        public void FactorialWithoutrecursion(int value)
        {
            var result = 1;

            for(int i = value; i > 0; i--)
            {
                result = result * i;
            }

            Console.WriteLine(result);
        }

        public long FactorialWithRecursion(int value)
        {
            if(value == 1)
            {
                return 1;
            }

            return value * FactorialWithRecursion(value-1);
        }
    }
}
