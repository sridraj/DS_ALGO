using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms
{
    public class StackUsingArray
    {
        private ArrayList stack;
        private int top;

        public StackUsingArray()
        {
            stack = new ArrayList();
            top = -1;
        }

        public void Push(object value)
        {
            stack.Add(value);
            top++;
        }

        public object Pop()
        {
            if(top == -1)
            {
                return "Stack is Empty";
            }

            var item = stack[top];
            stack.RemoveAt(top);
            top-- ;
            return item;
        }

        public void Peek()
        {
            if(top == -1)
            {
                Console.WriteLine( "Stack is Empty" );
            }

            else
            {
                Console.WriteLine("Peek --" + stack[top]);
            }
        }

        public void PrintStack()
        {
            if(top == -1)
            {
                Console.Write("Stack is Empty");
            }

            for (int i = 0; i <= top; i++)
            {
                Console.Write("-->" + stack[i]);
            }
        }
    }
}
