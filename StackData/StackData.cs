using System;
using System.Collections.Generic;
using System.Text;

namespace StackDataStructure
{
    internal class StackData
    {
        public void Display()
        {
            Stack<int> Number = new Stack<int>();
            Number.Push(70);
            Number.Push(30);
            Number.Push(56);
            foreach (int i in Number)
            {
                Console.WriteLine(i);
            }
        }
    }
}
