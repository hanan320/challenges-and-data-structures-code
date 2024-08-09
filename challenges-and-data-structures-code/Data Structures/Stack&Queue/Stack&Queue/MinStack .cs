using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Queue
{
    public class MinStack:Stack_ex
    {
        private Stack_ex minStack;

        public MinStack() : base()
        {
            minStack = new Stack_ex();
        }

        public int GetMin()
        {
            if (minStack.IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            int min =minStack.Peek();

            while (!minStack.IsEmpty())
            {

                minStack.Push(minStack.Pop());
                if (minStack.Peek() < min)
                    min = minStack.Peek();
            }

            while (!minStack.IsEmpty())
            {
                minStack.Push(minStack.Pop());
            }

            return min;

        }
    }
}
