using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms
{
    public class stackNode
    {
        public object value;
        public stackNode next;

        public stackNode(object _value)
        {
            value = _value;
            next = null;
        }
    }

    public class StackUsingLinkedList
    {
        private stackNode top;
        private stackNode bottom;
        private int length;

        public StackUsingLinkedList()
        {
            top = null;
            bottom = top;
            length = 0;
        }

        public void Push(object value)
        {
            if(length == 0)
            {
                CreateFirstNode(value);
                return;
            }

            var newTop = new stackNode(value);
            newTop.next = top;
            top = newTop;
            length++;
        }

        public void Pop()
        {
            if(length == 0)
            {
                Console.WriteLine("no data in stack");
                return;
            }

            var popItem = top.value;
            top = top.next;
            length--;
        }

        public void Peek()
        {
            if(length == 0)
            {
                Console.WriteLine("no data");
                return;
            }

            Console.WriteLine("Peek value = " + top.value);
        }

        public void PrintStack()
        {
            if (length == 0)
            {
                Console.WriteLine("no data");
                return;
            }

            var temp = top;

            for(int i = 0; i < length; i++)
            {
                Console.Write("-->" + temp.value);
                temp = temp.next;
            }
        }

        public void CreateFirstNode(object value)
        {
            top = new stackNode(value);
            top.next = null;
            bottom = top;
            length++;
        }
    }
}
