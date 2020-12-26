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

            //var a = new MergeSortedArrays();
            //int[] array1 = { 1, 2, 6, 78, 99 };
            //int[] array2 = { 5, 6, 8, 66, 90, 110 };
            //var mergesSortedArrays = a.MergeTwoSortedArrays(array1, array2);

            //var hashClass = new HashTableImplementation(2);
            //hashClass.SetValue("Sriditya", 25);
            //hashClass.SetValue("Raj", 26);
            //hashClass.SetValue("David", 55);
            //hashClass.SetValue("Thomas", 21);
            //hashClass.SetValue("Juan", 23);
            //hashClass.SetValue("Kylie", 36);




            //var hashTableGetValue = hashClass.GetValue("Raj");
            //var hashTableGetValue2 = hashClass.GetValue("Sriditya");
            //var hashTableGetValue3 = hashClass.GetValue("David");

            //var keys = hashClass.GetKeys();

            var x = new FindFirstRecurringCharacter();
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4 };
            var firstRecurringCharacter = x.FindFirstRecurringNumberUsingHash(arr);
            var firstRecurringCharacterUsingList = x.FindFirstRecurringNumberUsingList(arr);


        }
    }
}
