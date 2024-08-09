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
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            int min = int.MaxValue; // Initialize to a very large value
            Stack_ex tempStack = new Stack_ex();

            // Traverse the stack to find the minimum value
            while (!IsEmpty())
            {
                int current = Pop();
                if (current < min)
                {
                    min = current;
                }
                tempStack.Push(current); // Push to a temporary stack to restore the original stack
            }

            // Restore the original stack
            while (!tempStack.IsEmpty())
            {
                Push(tempStack.Pop());
            }

            return min;
        }
    }
}
