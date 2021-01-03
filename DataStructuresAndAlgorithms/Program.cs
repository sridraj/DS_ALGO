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

            //var x = new FindFirstRecurringCharacter();
            //int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4 };
            //var firstRecurringCharacter = x.FindFirstRecurringNumberUsingHash(arr);
            //var firstRecurringCharacterUsingList = x.FindFirstRecurringNumberUsingList(arr);

            //var singlyLinkedList = new SinglyLinkedList();
            //singlyLinkedList.Append(1);
            //singlyLinkedList.Append(5);
            //singlyLinkedList.Append(10);
            //singlyLinkedList.Append(1);
            //singlyLinkedList.Prepend(15);
            //singlyLinkedList.Append(20);
            //singlyLinkedList.InsertAtindex(3, 110);
            //singlyLinkedList.InsertAtindex(0, 32);
            //singlyLinkedList.InsertAtindex(7, 150);
            //singlyLinkedList.DeleteAtIndex(4);
            //singlyLinkedList.ReverseLinkedList();
            //singlyLinkedList.PrintList();

            //var doublyList = new DoublyLinkedList();
            //doublyList.Append(1);
            //doublyList.Append(5);
            //doublyList.Append(10);
            //doublyList.Append(1);
            //doublyList.Prepend(15);
            //doublyList.Append(20);

            //doublyList.InsertAtIndex(3, 110);
            //doublyList.InsertAtIndex(0, 32);
            //doublyList.InsertAtIndex(7, 150);
            //doublyList.DeleteAtIndex(6);
            //doublyList.PrintList();

            //var stackClass = new StackUsingArray();
            //stackClass.Push("Sriditya");
            //stackClass.Push("Raj");
            //stackClass.Push("Johnson");
            //stackClass.Push("Philips");
            //stackClass.Pop();
            //stackClass.Pop();
            //stackClass.Push("Amanda");
            //stackClass.Peek();
            //stackClass.PrintStack();


            //var stackClass2 = new StackUsingLinkedList();
            //stackClass2.Push("Sriditya");
            //stackClass2.Push("Raj");
            //stackClass2.Push("Johnson");
            //stackClass2.Push("Philips");
            //stackClass2.Pop();
            //stackClass2.Pop();
            //stackClass2.Push("Amanda");
            //stackClass2.Peek();
            //stackClass2.PrintStack();

            //var queueClass = new QueueWithLinkedList();
            //queueClass.Enqueue("Sriditya");
            //queueClass.Enqueue("Raj");
            //queueClass.Enqueue("Johnson");
            //queueClass.Enqueue("Philips");
            //queueClass.PrintQueue();
            //queueClass.Dequeue();
            //queueClass.PrintQueue();
            //queueClass.Dequeue();
            //queueClass.PrintQueue();
            //queueClass.Enqueue("Amanda");
            //queueClass.Peek();
            //queueClass.PrintQueue();


            //var queueClass2 = new QueueWithStack(); 
            //queueClass2.Enqueue("Sriditya");
            //queueClass2.Enqueue("Raj");
            //queueClass2.Enqueue("Johnson");
            //queueClass2.Enqueue("Philips");
            //queueClass2.PrintQueue();
            //queueClass2.Dequeue();
            //queueClass2.PrintQueue();
            //queueClass2.Dequeue();
            //queueClass2.PrintQueue();
            //queueClass2.Enqueue("Amanda");
            //queueClass2.Peek();
            //queueClass2.PrintQueue();


            //var bstClass = new BinarySearchTree();
            //bstClass.Insert(9);
            //bstClass.Insert(4);
            //bstClass.Insert(6);
            //bstClass.Insert(20);
            //bstClass.Insert(170);
            //bstClass.Insert(15);
            //bstClass.Insert(1);
            //var a = bstClass.LookUp(20);
            //bstClass.printTree(bstClass.root);

            var pqClass = new PriorityQueue();
            pqClass.Enqueue("Sriditya", 14);
            pqClass.Enqueue("Raj", 12);
            pqClass.Enqueue("David", 3);
            pqClass.Enqueue("Ashok", 8);
            pqClass.Enqueue("Greene", 4);
            pqClass.Enqueue("Paul", 13);
            pqClass.Enqueue("Pete", 1);
            pqClass.PrintPriorityQueue();
            pqClass.Dequeue();
            pqClass.Enqueue("Sri", 15);


        }
    }
}
