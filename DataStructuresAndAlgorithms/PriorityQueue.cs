using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms
{
    public class PQNode
    {
        public object data { get; set; }

        //larger value for higher priority
        public int priority { get; set; }
        public PQNode next { get; set; }

        public PQNode(object _value, int _priority)
        {
            data = _value;
            priority = _priority;
            next = null;
        }
    }

    public class PriorityQueue
    {
        private PQNode first;

        public PriorityQueue()
        {
            first = null;
        }

        public void Enqueue(object _data, int _priority)
        {
            if(first == null)
            {
                EnqueueFirstItem(_data, _priority);
                return;
            }

            if(_priority > first.priority)
            {
                var newFirstNode = new PQNode(_data, _priority);
                newFirstNode.next = first;
                first = newFirstNode;
                return;
            }

            var tempNode = first;

            while(tempNode.next != null && _priority < tempNode.next.priority) 
            {
                tempNode = tempNode.next;
            }

            var newItem = new PQNode(_data, _priority);
            newItem.next = tempNode.next;
            tempNode.next = newItem;
        }

        public void Dequeue()
        {
            if(first == null)
            {
                return;
            }

            first = first.next;            
        }

        public void PrintPriorityQueue()
        {
            var currentNode = first;

            if(currentNode == null)
            {
                return;
            }

            while(currentNode != null)
            {
                Console.WriteLine("Priority = " + currentNode.priority + "   Value = " + currentNode.data);
                currentNode = currentNode.next;
            }
        }

        private void EnqueueFirstItem(object _data, int _priority)
        {
            first = new PQNode(_data, _priority);
        }
    }
}
