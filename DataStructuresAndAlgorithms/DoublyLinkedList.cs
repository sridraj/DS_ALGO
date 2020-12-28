using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms
{
    public class DoublyLinkedListNode
    {
        public int value { get; set; }
        public DoublyLinkedListNode next { get; set; }
        public DoublyLinkedListNode prev { get; set; }
        public DoublyLinkedListNode(int _value)
        {
            value = _value;
            next = null;
            prev = null;
        }
    }
    public class DoublyLinkedList
    {
        private DoublyLinkedListNode head;
        private DoublyLinkedListNode tail;
        private int length;
        public DoublyLinkedList()
        {
            length = 0;
        }

        public void Append(int value)
        {
            if (length == 0)
            {
                CreateFirstNode(value);
                return;
            }

            var newTail = new DoublyLinkedListNode(value);
            newTail.prev = tail;
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

            var newHead = new DoublyLinkedListNode(value);
            head.prev = newHead;
            newHead.prev = null;
            newHead.next = head;
            head = newHead;
            length++;
        }

        public void InsertAtIndex(int index, int value)
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

            var newNode = new DoublyLinkedListNode(value);
            bool isTraverseOrderFwd = (length - index) >= (length / 2);
            var prevNode = TraverseToPrevNode(index, isTraverseOrderFwd);

            if (isTraverseOrderFwd)
            {
                newNode.prev = prevNode;
                newNode.next = prevNode.next;
                prevNode.next = newNode;
                length++;
                return;
            }

            else
            {
                newNode.next = prevNode;
                newNode.prev = prevNode.prev;
                prevNode.prev = newNode;
                length++;
                return;
            }
        }

        public void DeleteAtIndex(int index)
        {
            if(index == 0)
            {
                head = head.next;
                head.prev = null;
                length--;
                return;
            }

            bool isTraverseOrderFwd = (length - index) >= (length / 2);
            var prevNode = TraverseToPrevNode(index, isTraverseOrderFwd);

            if(isTraverseOrderFwd)
            {
                var nodeToDelete = prevNode.next;
                var nextNode = nodeToDelete.next;

                prevNode.next = nextNode;
                nextNode.prev = prevNode;
                length--;
            }

            else
            {
                var nodeToDelete = prevNode.prev;
                var nextNode = nodeToDelete.prev;

                prevNode.prev = nextNode;
                nextNode.next = prevNode;
                length--;
            }
        }

        public void PrintList()
        {
            var node = head;
            for(int i = 0; i < length; i++)
            {
                Console.Write("-->" + node.value);
                node = node.next;
            }
        }

        public void CreateFirstNode(int value)
        {
            head = new DoublyLinkedListNode(value);
            head.prev = null;
            head.next = null;
            tail = head;
            length++;
        }

        public DoublyLinkedListNode TraverseToPrevNode(int index, bool isTraverseOrderFwd)
        {

            if(!isTraverseOrderFwd)
            {
                var prevNode = tail;
                for(int i = length-1; i > index + 1 ; i--)
                {
                    prevNode = prevNode.prev;
                }

                return prevNode;
            }

            else
            {
                var prevNode = head;

                for (int i = 0; i <  index - 1; i++)
                {
                    prevNode = prevNode.next;
                }

                return prevNode;
            }
        }
    }
}
