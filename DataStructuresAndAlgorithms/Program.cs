using System;

namespace DataStructuresAndAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //var array = new StringReversal();
            //var reversedString = array.ReverseString2("Hi My name is Sriditya");
            //Console.WriteLine(reversedString);

            var a = new MergeSortedArrays();
            int[] array1 = { 1, 2, 6, 78, 99 };
            int[] array2 = { 5, 6, 8, 66, 90, 110 };
            var mergesSortedArrays = a.MergeTwoSortedArrays(array1, array2);
        }
    }
}
