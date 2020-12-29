using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms
{
    public class queueNode
    {
        public object value { get; set; }
        public queueNode next { get; set; }
        
        public queueNode(object _value)
        {
            value = _value;
            next = null;
        }
    }

    public class QueueWithLinkedList
    {
        private queueNode first;
        private queueNode last;
        private int length;

        public QueueWithLinkedList()
        {
            first = null;
            last = first;
            length = 0;
        }

        public void Enqueue(object value)
        {
            if(length == 0)
            {
                CreateFirstNode(value);
                return;
            }

            var newLast = new queueNode(value);
            last.next = newLast;
            last = newLast;
            length++;
        }

        public void Dequeue()
        {
            if(length == 0)
            {
                Console.WriteLine("no data in queue");
                return;
            }

            Console.WriteLine("dequeued item is = " + first.value);
            var item = first;
            first = first.next;
            length--;
        }

        public void Peek()
        {
            if(length == 0)
            {
                Console.WriteLine("no data");
                return;
            }

            Console.WriteLine("Peek Value = " + first.value);
        }

        public void PrintQueue()
        {
            Console.WriteLine("");

            if(length == 0)
            {
                Console.WriteLine("no data to  print");
                return;
            }

            var temp = first;


            for(int i = 0; i < length; i++)
            {
                Console.Write("-->" + temp.value);
                temp = temp.next;
            }
        }

        private void CreateFirstNode(object value)
        {
            first = new queueNode(value);
            last = first;
            length++;
        }
    }
}
