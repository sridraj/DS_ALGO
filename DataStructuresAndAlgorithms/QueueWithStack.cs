using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms
{
    public class QueueWithStack
    {
        private Stack<object> mainStack;
        private Stack<object> tempStack;

        public QueueWithStack()
        {
            mainStack = new Stack<object>();
            tempStack = new Stack<object>();
        }

        public void Enqueue(object value)
        {
            mainStack.Push(value);
        }

        public object Dequeue()
        {
            PushToTempStack();
            var item = tempStack.Pop();
            PushToMainStack();
            return item;
        }

        public object Peek()
        {
            PushToTempStack();
            var item = tempStack.Peek();
            PushToMainStack();
            return item;
        }

        public void PrintQueue()
        {
            PushToTempStack();
           foreach(var i in tempStack)
            {
                Console.WriteLine(i);
            }

            PushToMainStack();
        }

        private void PushToTempStack()
        {
            while (mainStack.Count != 0)
            {
                tempStack.Push(mainStack.Pop());
            }
        }

        private void PushToMainStack()
        {
            while (tempStack.Count != 0)
            {
                mainStack.Push(tempStack.Pop());
            }
        }
    }
}
