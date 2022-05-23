using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackDataStructure
{
    internal class QueueData
    {
        Queue<int> Number = new Queue<int>();
        public void Display()
        {
            Number.Enqueue(56);
            Number.Enqueue(30);
            Number.Enqueue(70);
            foreach (int i in Number)
            {
                Console.WriteLine(i);
            }
        }
        
    }
}
