using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackDataStructure
{
    internal class StackData
    {
        Stack<int> Number = new Stack<int>();
        public void Display()
        {
            Number.Push(70);
            Number.Push(30);
            Number.Push(56);
            Console.WriteLine("Before POP");
            foreach (int i in Number)
            {
                Console.WriteLine(i);
            }
        }
        public void Pop()
        {
            Console.WriteLine("After POP");
            Number.Pop();
            Number.Pop();
            Number.Pop();

            foreach (int i in Number)
            {

                Console.WriteLine(i);
            }
        }
    }
}
