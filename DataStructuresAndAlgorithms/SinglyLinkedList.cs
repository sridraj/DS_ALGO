using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms
{
    public class LinkedListNode
    {
        public int value { get; set; }
        public LinkedListNode next { get; set; }

        public LinkedListNode(int _value)
        {
            value = _value;
            next = null;
        }
    }
    public class SinglyLinkedList
    {
        private LinkedListNode head;
        private LinkedListNode tail;
        private int length;
        public SinglyLinkedList()
        {
            length = 0;
        }

        public void Append(int value)
        {
            if(length == 0)
            {
                CreateFirstNode(value);
                return;
            }

            var newTail = new LinkedListNode(value);
            newTail.next = null;
            tail.next = newTail;
            tail = newTail;
            length++;
        }

        public void Prepend(int value)
        {
            if(length == 0)
            {
                CreateFirstNode(value);
                return;
            }

            var newHead = new LinkedListNode(value);
            newHead.next = head;
            head = newHead;
            length++;
        }

        public void InsertAtindex(int index, int value)
        {
            if(index == 0)
            {
                Prepend(value);
                return;
            }

            if(index == length-1)
            {
                Append(value);
                return;
            }

            LinkedListNode prevNode = head;

            for(int i = 0; i < index - 1; i++)
            {
                prevNode = prevNode.next;
            }

            var newNode = new LinkedListNode(value);
            newNode.next = prevNode.next;
            prevNode.next = newNode;
            length++;
        }

        public void DeleteAtIndex(int index)
        {
            if(index == 0)
            {
                head = head.next;
                length--;
                return;
            }

            LinkedListNode prevNode = head;
            for(int i = 0; i < index - 1; i++)
            {
                prevNode = prevNode.next;
            }

            LinkedListNode nodeToDelete = prevNode.next;
            prevNode.next = nodeToDelete.next;
            length--;
        }

        public void ReverseLinkedList()
        {
            if(length == 1)
            {
                return;
            }

            LinkedListNode prevNode = head;
            var tempNode = head;
            head = tail;
            tail = tempNode;
            LinkedListNode nextNode = prevNode.next;

            for(int i = 0; i < length - 1; i++)
            {
                LinkedListNode temp = nextNode.next;
                nextNode.next = prevNode;
                prevNode = nextNode;
                nextNode = temp;
            }
        }

        public void PrintList()
        {
            int count = length;
            if(count == 0)
            {
                Console.Write("No data in linked list");
                return;
            }

            while(count != 0)
            {
                Console.Write("-->" + head.value.ToString());
                head = head.next;
                count--;
            }
        }

        public void CreateFirstNode(int value)
        {
            head = new LinkedListNode(value);
            tail = head;
            length++;
        }
    }
}
